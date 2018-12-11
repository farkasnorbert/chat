#ifndef SZERVER_SYSTHREAD_H
#define SZERVER_SYSTHREAD_H

#include <iostream>
#include <limits.h>
#include <Winsock2.h>

class SysThread {
public:
    SysThread(void);

    virtual ~SysThread();

    virtual bool start(void);

    virtual bool stop(unsigned int timeout = 0);

    inline volatile bool &isRunning(void) {
        return m_bRunning;
    }

    inline volatile bool &isExited(void) {
        return m_bExited;
    }

protected:
    virtual void
    run(); //Ezt a metodust a származtatott osztályban felül kell írni.Ide kell beírni az utasítás szekvenciát amit a szálunk végre kell hajtson
private:
    friend DWORD WINAPI runStub(LPVOID mthread);

public:
    static const unsigned int INFINIT_WAIT;
    SOCKET AcceptSocket;

    void setSocket(SOCKET);

private:
    volatile bool m_bRunning;
    volatile bool m_bExited;
    HANDLE m_thread;
};


#endif //SZERVER_SYSTHREAD_H
