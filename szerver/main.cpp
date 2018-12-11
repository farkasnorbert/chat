#include <iostream>
#include "winsock2.h"
#include <stdio.h>
#include <vector>
#pragma comment(lib, "ws2_32.lib")
#define _WINSOCK_DEPRECATED_NO_WARNINGS
int main() {
    // Initialize Winsock.
    WSADATA wsaData;

    int iResult = WSAStartup(MAKEWORD(2, 2), &wsaData);//
    if (iResult != 0) {
        printf("Error at WSAStartup()\n");
        return 1;
    }
    // Create a SOCKET for listening for
    // incoming connection requests
    SOCKET ListenSocket;
    ListenSocket = socket(AF_INET, SOCK_STREAM, IPPROTO_TCP);//szoket csalad
    if (ListenSocket == INVALID_SOCKET) {
        printf("Error at socket(): %ld\n", WSAGetLastError());
        WSACleanup();
        return 2;
    }
    //----------------------
    // The sockaddr_in structure specifies the address family,
    // IP address, and port for the socket that is being bound.
    const int RecBufLen = 1024;//karakter hossz
    sockaddr_in RecvAddr;//port ip kapcsolatot nyit
    const int Port = 10013;
    RecvAddr.sin_family = AF_INET;
    RecvAddr.sin_addr.s_addr = inet_addr("127.0.0.1");
    RecvAddr.sin_port = htons(Port);//konfiguraljuk a portot
    //porton folyo komunikaciot lehalgatja ess koveti
    if (::bind(ListenSocket,(SOCKADDR*)&RecvAddr,sizeof(RecvAddr)) == SOCKET_ERROR) {
        printf("bind() failed.\n");
        closesocket(ListenSocket);
        WSACleanup();
        return 3;
    }
    int numOfClients = 0;
    //std::vector<MyThread *> clients;
    std::vector<SOCKET*> sockets;//uj kliens id lessz
    // Create a SOCKET for accepting incoming requests.
    SOCKET AcceptSocket;//uj szoket letrehozas amit osszekotok egy kero klienshez
    sockets.push_back(new SOCKET);
    while(true){
        std::cout<<1;
        break;
    }
    // Clean up and quit.
    printf("Exiting.\n");
    WSACleanup();
    return 0;
}