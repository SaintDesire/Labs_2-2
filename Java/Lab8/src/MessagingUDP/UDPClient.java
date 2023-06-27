import java.io.IOException;
import java.net.DatagramPacket;
import java.net.DatagramSocket;
import java.net.InetAddress;
import java.util.Scanner;

public class UDPClient {
    private DatagramSocket socket;
    private InetAddress address;
    private int port;

    public UDPClient(String serverAddress, int port) throws IOException {
        socket = new DatagramSocket();
        address = InetAddress.getByName(serverAddress);
        this.port = port;
    }

    public void send(String message) throws IOException {
        byte[] sendData = message.getBytes();
        DatagramPacket packet = new DatagramPacket(sendData, sendData.length, address, port);
        socket.send(packet);

        byte[] buffer = new byte[1024];
        DatagramPacket receivePacket = new DatagramPacket(buffer, buffer.length);
        socket.receive(receivePacket);
        String response = new String(receivePacket.getData(), 0, receivePacket.getLength());
        System.out.println("Received response: " + response);
    }

    public static void main(String[] args) throws IOException {
        UDPClient client = new UDPClient("localhost", 8080);

        Scanner scanner = new Scanner(System.in);
        while (true) {
            System.out.print("Enter message to send: ");
            String message = scanner.nextLine();

            client.send(message);
        }
    }
}
