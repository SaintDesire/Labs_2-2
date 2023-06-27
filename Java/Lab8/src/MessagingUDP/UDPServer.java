package MessagingUDP;
import java.io.IOException;
import java.net.DatagramPacket;
import java.net.DatagramSocket;
import java.net.InetAddress;

public class UDPServer {
    private DatagramSocket socket;

    public UDPServer(int port) throws IOException {
        socket = new DatagramSocket(port);
    }

    public void listen() throws IOException {
        byte[] buffer = new byte[1024];
        DatagramPacket packet = new DatagramPacket(buffer, buffer.length);

        while (true) {
            socket.receive(packet);

            String message = new String(packet.getData(), 0, packet.getLength());
            System.out.println("Received message: " + message);

            InetAddress address = packet.getAddress();
            int port = packet.getPort();

            byte[] sendData = message.getBytes();
            DatagramPacket sendPacket = new DatagramPacket(sendData, sendData.length, address, port);
            socket.send(sendPacket);
        }
    }

    public static void main(String[] args) throws IOException {
        UDPServer server = new UDPServer(8080);
        server.listen();
    }
}
