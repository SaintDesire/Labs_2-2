package GetResources;

import java.net.*;
import java.io.*;

public class GetResources {
    public static void main(String[] args) {
        try {
            URL url = new URL("https://it.belstu.by");
            URLConnection conn = url.openConnection();
            BufferedReader in = new BufferedReader(new InputStreamReader(conn.getInputStream()));

            String inputLine;
            while ((inputLine = in.readLine()) != null) {
                System.out.println(inputLine);
            }
            in.close();
        } catch (Exception e) {
            System.out.println(e);
        }
    }
}
