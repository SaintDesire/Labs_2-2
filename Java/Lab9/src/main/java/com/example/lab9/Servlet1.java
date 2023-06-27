package com.example.lab9;

import jakarta.servlet.*;
import jakarta.servlet.http.*;
import jakarta.servlet.annotation.*;

import java.io.IOException;
import java.io.PrintWriter;
import java.text.DateFormat;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.Enumeration;

@WebServlet(name = "Servlet1", value = "/Servlet1")
public class Servlet1 extends HttpServlet {

    @Override
    protected void doGet(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {

        response.setContentType("text/html");
        PrintWriter out = response.getWriter();

        DateFormat dateFormat = new SimpleDateFormat("yyyy/MM/dd HH:mm:ss");
        Date date = new Date();
        String time = dateFormat.format(date);

        out.println("<html>");
        out.println("<head><title>Current Time</title></head>");
        out.println("<body>");
        out.println("<h2>Current Time is: " + time + "</h2>");

        // Получение информации о запросе
        out.println("<h3>Request Information:</h3>");
        out.println("<p>Protocol: " + request.getProtocol() + "</p>");
        out.println("<p>Client IP Address: " + request.getRemoteAddr() + "</p>");
        out.println("<p>Client Host Name: " + request.getRemoteHost() + "</p>");
        out.println("<p>Method: " + request.getMethod() + "</p>");
        out.println("<p>Request URL: " + request.getRequestURL() + "</p>");

        // Получение заголовков запроса
        out.println("<h3>Request Headers:</h3>");
        out.println("<ul>");
        Enumeration<String> headerNames = request.getHeaderNames();
        while(headerNames.hasMoreElements()) {
            String headerName = headerNames.nextElement();
            String headerValue = request.getHeader(headerName);
            out.println("<li>" + headerName + ": " + request.getHeader(headerValue) + "</li>");
        }
        out.println("</ul>");

        out.println("</body></html>");
    }
}
