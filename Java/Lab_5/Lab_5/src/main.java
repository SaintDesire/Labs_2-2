import Ex1.CallCentre.CallCenter;
import Ex1.CallCentre.Operator;
import Ex2.Parking.Parking;
import java.util.concurrent.Semaphore;

public class main {
    public static void main(String[] args) {

        //----------ex_1-----------
//        Operator operator1 = new Operator(1);
//        Operator operator2 = new Operator(2);
//        Operator operator3 = new Operator(3);
//
//        Operator[] arrOfOperator = {operator1, operator2, operator3};
//        Semaphore sem1 = new Semaphore(3);
//        for (int i = 1; i<=10; i++)
//        {
//            new CallCenter(sem1, i, arrOfOperator).start();
//        }

//        ------------------------
//        ----------ex_2-----------

        Semaphore sem2 = new Semaphore(1);
        for (int i = 0; i<8; i++)
        {
            new Parking(sem2, i).start();
        }
    }
}
