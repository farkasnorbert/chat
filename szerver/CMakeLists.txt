cmake_minimum_required(VERSION 3.12)
project(szerver)

set(CMAKE_CXX_STANDARD 14)
link_libraries(ws2_32 wsock32)

add_executable(szerver main.cpp SysThread.cpp SysThread.h)