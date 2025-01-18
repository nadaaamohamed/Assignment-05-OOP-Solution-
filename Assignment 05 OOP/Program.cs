using Assignment_05_OOP.Question_02;
using Assignment_05_OOP.Question_03;

namespace Assignment_05_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1.
            /*
            Define an interface named IShape with a property Area and a method DisplayShapeInfo. Create two interfaces, ICircle and IRectangle, 
            that inherit from IShape. Implement these interfaces in classes Circle and Rectangle. Test your implementation by creating instances
            of both classes and displaying their shape information.
            */

            //ICircle circle = new Circle();
            //circle.Radies = 5;
            //circle.DisplayShapeInfo();

            //IRectangle rectangle = new Rectangle();
            //rectangle.Length = 5;
            //rectangle.Width = 10;
            //rectangle.DisplayShapeInfo();

            #endregion
            #region Q2.
            /*
             * In this example, 
            1-We start by defining the IAuthenticationService interface with two methods: AuthenticateUser and AuthorizeUser. 
            The BasicAuthenticationService class implements this interface and provides the specific implementation for these methods.
            2-In the BasicAuthenticationService class, the AuthenticateUser method compares the provided username and password with the stored
            credentials. It returns true if the user is authenticated and false otherwise. The AuthorizeUser method checks if the user
            with the given username has the specified role. It returns true if the user is authorized and false otherwise.
            3-In the Main method, we create an instance of the BasicAuthenticationService class and assign it to the authService variable of type
            IAuthenticationService. We then call the AuthenticateUser and AuthorizeUser methods using this interface reference..
            This implementation allows you to switch the authentication service implementation easily by creating a new class that implements the
            IAuthenticationService interface and providing the desired logic for authentication and authorization.
            */
            //IAuthenticationService authService = new BasicAuthenticationService();
            //bool isAuthentication = authService.Authenticate("admin", "123N");
            //Console.WriteLine(isAuthentication);

            //isAuthentication= authService.AuthorizeUser("admin", "Manager");
            //Console.WriteLine(isAuthentication);
            //if(authService.Authenticate("admin", "omar"))
            //{
            //    Console.WriteLine("User is authenticated");
            //}
            //else
            //{
            //    Console.WriteLine("User is not authenticated");
            //}




            #endregion
            #region Q3.
            /*
             1-we define the INotificationService interface with a method SendNotification that takes a recipient and a message as parameters.
             2-We then create three classes: EmailNotificationService, SmsNotificationService, and PushNotificationService, which implement the INotificationService interface.
             3-In each implementation, we provide the logic to send notifications through the respective communication channel:
             4-The EmailNotificationService class simulates sending an email by outputting a message to the console.
             5-The SmsNotificationService class simulates sending an SMS by outputting a message to the console.
             6-The PushNotificationService class simulates sending a push notification by outputting a message to the console.
             7-In the Main method, we create instances of each notification service class and call the SendNotification method with sample recipient and message values.
             This implementation allows you to easily switch between different notification channels by creating new classes that implement the INotificationService interface and provide the specific logic for each channel.
            
             */
            //INotificationService emailNotificationService = new EmailNotificationService();
            //emailNotificationService.SendNotification("Nada@gmail.com" , "Hello Nada");

            //INotificationService smsNotificationService = new SmsNotificationService();
            //smsNotificationService.SendNotification("01000000000", "Hello Nada");

            //INotificationService pushNotificationService = new PushNotificationService();
            //pushNotificationService.SendNotification("Nada", "Hello Nada");




            #endregion
        }
    }
}
