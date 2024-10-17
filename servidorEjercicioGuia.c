#include <string.h>
#include <unistd.h>
#include <stdlib.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <stdio.h>
#include <pthread.h>

//Variable para ir contado los servicios realizados
int contador;

//Estructura necesaria para acceso excluyente
pthread_mutex_t mutex = PTHREAD_MUTEX_INITIALIZER;

//Definimos estructuras i funciones para trabajar con la lista de conectados
typedef struct {
	char nombre[20];
	int socket;
} Conectado;

typedef struct {
	Conectado conectados[100];
	int num;
} ListaConectados;

int PonConectado(ListaConectados* lista, char nombre[20], int socket) {
	//Añade nuevo conectado a una lista de conectados
	//Devuelva -1 si la llista esta llena, 0 si se ha hecho correctamente
	if (lista->num == 100)
		return -1;
	else {
		strcpy(lista->conectados[lista->num].nombre, nombre);
		lista->conectados[lista->num].socket = socket;
		lista->num++;
		return 0;

	}
}
int DamePosicion(ListaConectados* lista, char nombre[20]) {
	//Devuelve posicon en la lista o -1 si  no está en la lista de conectado
	int i = 0;
	int encontrado = 0;
	while ((i < lista->num) && !encontrado)
	{
		if (strcmp(lista->conectados[i].nombre, nombre) == 0)
			encontrado = 1;
		else if (!encontrado)
			i = i + 1;
	}
	if (encontrado)
		return i;
	else
		return -1;
}

int EliminaConectado(ListaConectados* lista, char nombre[20]) {
	//Retorna 0 si elimina y -1 si ese usuario no esta en la lista
	//Primero con el algoritmo de busqueda buscamos la posicion del nombre
	int pos = DamePosicion(lista, nombre);
	if (pos == -1)
		return -1;
	else {
		int i;
		for (i = pos; i < lista->num - 1; i++)
		{
			strcpy(lista->conectados[i].nombre, lista->conectados[i + 1].nombre);
			lista->conectados[i].socket = lista->conectados[i + 1].socket;
		}
		lista->num--;
		return 0;
	}
}

void DameConectados(ListaConectados* lista, char conectados[300]) {
	//Escribe en la char de conectados los nombre de todos los coenctados separados por /
	//Primero Pone el numero de conectados: 3/Pedro/Maria/Juan
	sprintf(conectados, "%d", lista->num);
	int i;
	for (i = 0; i < lista->num; i++)
		sprintf(conectados, "%s/%s", conectados, lista->conectados[i].nombre);

}



void* AtenderCliente(void* socket)
{
	int sock_conn;
	int *s;
	s= (int *) socket;
	sock_conn = *s;

	//int socket_conn = * (int *) socket;

	char peticion[512];
	char respuesta[512];
	int ret;


	int terminar = 0;
	// Entramos en un bucle para atender todas las peticiones de este cliente
	//hasta que se desconecte
	while (terminar == 0)
	{
		// Ahora recibimos la petici?n
		ret = read(sock_conn, peticion, sizeof(peticion));
		printf("Recibido\n");

		// Tenemos que a?adirle la marca de fin de string 
		// para que no escriba lo que hay despues en el buffer
		peticion[ret] = '\0';


		printf("Peticion: %s\n", peticion);

		// vamos a ver que quieren
		char *p = strtok(peticion, "/");
		int codigo = atoi(p);
		// Ya tenemos el c?digo de la petici?n
		char nombre[20];

		if ((codigo != 0)&&(codigo!=6))
		{
			p = strtok(NULL, "/");

			strcpy(nombre, p);
			// Ya tenemos el nombre
			printf("Codigo: %d, Nombre: %s\n", codigo, nombre);
		}

		if (codigo == 0) //petici?n de desconexi?n
			terminar = 1;

		else if (codigo == 1) //piden la longitd del nombre
			sprintf(respuesta, "%d", strlen(nombre));

		else if (codigo == 2)
			// quieren saber si el nombre es bonito
			if ((nombre[0] == 'M') || (nombre[0] == 'S'))
				strcpy(respuesta, "SI");
			else
				strcpy(respuesta, "NO");

		else if (codigo == 3) //quiere saber si es alto
		{
			p = strtok(NULL, "/");
			float altura = atof(p);
			if (altura > 1.70)
				sprintf(respuesta, "%s: eres alto", nombre);
			else
				sprintf(respuesta, "%s: eresbajo", nombre);
		}

		else if (codigo == 4) //decir si es palindromo
		{
			int inicio = 0;
			int encontrado = 0;
			int fin = strlen(nombre) - 1;

			while (inicio < fin)
			{
				if (nombre[inicio] != nombre[fin])
				{
					strcpy(respuesta, "NO");
					encontrado = 1;
				}
				inicio++;
				fin--;
			}
			if (encontrado == 0)
				strcpy(respuesta, "SI");
		}

		else if (codigo == 5)
		{
			int i;
			for (i = 0; nombre[i] != '\0'; i++)
			{
				//Comprobamos que los caracteres entres dentro de a-z
				if (nombre[i] >= 'a' && nombre[i] <= 'z') {
					respuesta[i] = nombre[i] - 32; // Restar 32 convierte una letra minúscula en mayúscula
				}
			}
		}

		else if (codigo == 6) {
			sprintf(respuesta, "%d", contador);
		}

		if (codigo != 0)
		{

			printf("Respuesta: %s\n", respuesta);
			// Enviamos respuesta
			write(sock_conn, respuesta, strlen(respuesta));
		}

		if ((codigo == 1) || (codigo == 2) || (codigo == 3) || (codigo == 4) || (codigo == 5)) {
			pthread_mutex_lock( &mutex); //No me interrumpas ahora
			contador++;
			pthread_mutex_unlock( &mutex); //Ya puedes interrumpirme
		}


	}
	// Se acabo el servicio para este cliente
	close(sock_conn);

}



int main(int argc, char *argv[])
{
	int sock_conn, sock_listen, ret;
	struct sockaddr_in serv_adr;

	// INICIALITZACIONS
	// Obrim el socket
	if ((sock_listen = socket(AF_INET, SOCK_STREAM, 0)) < 0)
		printf("Error creant socket");

	// Fem el bind al port
	memset(&serv_adr, 0, sizeof(serv_adr));// inicialitza a zero serv_addr
	serv_adr.sin_family = AF_INET;

	// asocia el socket a cualquiera de las IP de la m?quina. 
	//htonl formatea el numero que recibe al formato necesario
	serv_adr.sin_addr.s_addr = htonl(INADDR_ANY);
	// escucharemos en el port 9050
	serv_adr.sin_port = htons(9050);

	if (bind(sock_listen, (struct sockaddr *) &serv_adr, sizeof(serv_adr)) < 0)
		printf ("Error al bind");
	//La cola de peticiones pendientes no podr? ser superior a 4
	if (listen(sock_listen, 4) < 0)
		printf("Error en el Listen");

	contador = 0;
	int i = 0;
	int sockets[100];
	pthread_t thread;

	//Bucle infinito para no limitar el numero de conexiones y peticiones
	for (;;) 
	{
		printf("Escuchando\n");

		sock_conn = accept(sock_listen, NULL, NULL);
		printf("He recibido conexion\n");

		sockets[i] = sock_conn;
		//Sock_conn es el socket que usaremos para este cliente

		//Crear thread y decirle que tiene que hacer
		pthread_create (&thread, NULL, AtenderCliente, &sockets[i]);
		i++;
	}
}
