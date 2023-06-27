package com.example.test;

import java.io.*;
import java.sql.Connection;
import java.sql.DriverManager;

import jakarta.servlet.ServletException;
import jakarta.servlet.http.*;
import jakarta.servlet.annotation.*;

@WebServlet(name = "helloServlet", value = "/hello-servlet")
public class HelloServlet extends HttpServlet {
    private String message;

    public void init() {
        message = "Hello World!";
    }

    public void doGet(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {

        // JDBC настройки для подключения к MySQL базе данных
        String jdbcUrl = "jdbc:mysql://localhost:3306/AviaBooking";
        String jdbcUsername = "root";
        String jdbcPassword = "root";

        // попытка подключения к MySQL базе данных
        try {
            PrintWriter out = response.getWriter();
            out.println("<html><body>");
            out.println("<h2>Работа JDBC MySQL</h2>");
            Class.forName("com.mysql.jdbc.Driver");
            Connection conn = DriverManager.getConnection(jdbcUrl, jdbcUsername, jdbcPassword);
            out.println("<p>Подключение успешно!</p>");
            conn.close();
            out.println("</body></html>");
        } catch (Exception ex) {
            ex.printStackTrace();
        }
    }

    public void destroy() {
    }
}