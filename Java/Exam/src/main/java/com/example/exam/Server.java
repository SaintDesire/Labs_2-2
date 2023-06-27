package com.example.exam;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.PrintWriter;
import java.net.ServerSocket;
import java.net.Socket;

public class Server {
    private static int yesCount = 0;
    private static int noCount = 0;

    public static void main(String[] args) {
        try {
            ServerSocket serverSocket = new ServerSocket(2000);
            System.out.println("Сервер запущен.");

            while (true) {
                Socket clientSocket = serverSocket.accept();
                System.out.println("Новое подключение: " + clientSocket);

                ClientHandler clientHandler = new ClientHandler(clientSocket);
                clientHandler.start();
            }
        } catch (IOException e) {
            e.printStackTrace();
        }
    }

    private static synchronized void incrementYesCount() {
        yesCount++;
    }

    private static synchronized void incrementNoCount() {
        noCount++;
    }

    private static synchronized String getStatistics() {
        return "Статистика: Yes - " + yesCount + ", No - " + noCount;
    }

    private static class ClientHandler extends Thread {
        private Socket clientSocket;
        private PrintWriter out;
        private BufferedReader in;

        public ClientHandler(Socket socket) {
            this.clientSocket = socket;
        }

        public void run() {
            try {
                out = new PrintWriter(clientSocket.getOutputStream(), true);
                in = new BufferedReader(new InputStreamReader(clientSocket.getInputStream()));

                String inputLine;
                while ((inputLine = in.readLine()) != null) {
                    System.out.println("Получено сообщение от клиента: " + inputLine);

                    if (inputLine.equals("/yes")) {
                        incrementYesCount();
                    } else if (inputLine.equals("/no")) {
                        incrementNoCount();
                    } else if (inputLine.equals("/getall")) {
                        out.println(getStatistics());
                    } else if (inputLine.equals("/help")) {
                        out.println("Доступные команды: /yes, /no, /getall, /help");
                    }

                    if (inputLine.equals("exit")) {
                        break;
                    }
                }

                in.close();
                out.close();
                clientSocket.close();
                System.out.println("Клиент отключен.");
            } catch (IOException e) {
                e.printStackTrace();
            }
        }
    }
}

