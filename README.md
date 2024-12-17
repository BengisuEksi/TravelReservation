# Travel Reservation Application

This project simulates a travel reservation system where users can purchase bus tickets. It includes admin and user login screens, travel and driver management, passenger reservation operations, and other features. It is developed using C# and SQL.

## Database Structure

There are four main tables in the database:

1. Passengers: Contains personal information of passengers (name, surname, ID, phone, gender, mail, password).
2. Drivers: Contains driver information (driver number, full name, phone).
3. Ticket: Contains travel details (travel number, departure, arrival, date, time, driver, price).
4. Travel: Stores information about which passenger has booked a ticket for which travel (travel number, passenger ID, seat).

## C# Application Features

- Admin Login
  * The admin login screen includes fields for entering a username and password.
  * Login Information:
    * Username: user
    * Password: password

- Admin Screen
  * On the admin screen, the following actions can be performed:
    * New Route: Create, update, delete, and view existing travels.
    * New Driver: Create, update, delete, and view drivers. Each driver is automatically assigned a 4-digit driver number by the system.

- User Login
  * Users can log in with their ID and password. There is also a sign-up screen for users who wish to create an account. 

- New User
  * Users can create a new account by entering their first name, last name, ID, gender, phone, email, and password.

- User Screen
  * Once logged in, a personalized screen appears for the user with the following sections:
    * Reservation: Users can make a reservation with their passenger ID, selected seat and travel number. Seats are color-coded based on gender (pink for women, blue for men). Once the "Complete" button is pressed, the reservation is completed.
    * Bus Seats: Displays the current status of bus seats for the selected travel.
    * Profile: Displays the user's information, and they can update all details (except ID and gender). Users can delete their account and return to the login screen.
    * Tickets: Lists the trips the user has booked.
    * Available Routes: Lists all the routes user can choose from.

## Requirements
- .NET Framework.
- SQL Server or a compatible database connection.

![1](https://github.com/user-attachments/assets/b351a79f-061e-4c04-a1c5-076d40f876e5)

![2](https://github.com/user-attachments/assets/fb37b5cd-ffaf-4a05-8ab6-1d1050ce04d8)

![3](https://github.com/user-attachments/assets/f773ef85-798b-4f5d-882d-3e1a4e96a261)

![4](https://github.com/user-attachments/assets/e095abea-a728-4269-a0af-24c3342b6ac1)

![5](https://github.com/user-attachments/assets/fb15a7c5-10a2-4e94-b1d8-06729ac838e3)

![6](https://github.com/user-attachments/assets/339bd118-e7b0-45ce-a794-3b76b7096fb3)

![7](https://github.com/user-attachments/assets/b1eac703-f0a7-4391-ab53-1554be27d8fc)

![8](https://github.com/user-attachments/assets/0ede3963-cf7f-48c9-89fb-6e84d523a75e)

![9](https://github.com/user-attachments/assets/04d42502-17ad-4360-b80a-67bfa77c86bd)

![10](https://github.com/user-attachments/assets/4d0d7e3f-4ac2-45f2-a001-8074c6ac080f)

![11](https://github.com/user-attachments/assets/6fa374a2-bcde-4ea4-9171-b2ffc3e4ee47)

![12](https://github.com/user-attachments/assets/bb5c343e-f89f-4241-b01b-63363bb67b13)

![12 1](https://github.com/user-attachments/assets/aaf87f3a-0dc5-4878-8702-fa3fdeedf498)

![13](https://github.com/user-attachments/assets/c3870afa-55a8-406f-a81e-d55ba38f8ffb)

![14](https://github.com/user-attachments/assets/0383736f-e3b2-4957-bf4c-ff9b98cda54c)

![15](https://github.com/user-attachments/assets/70b54bd4-5e4a-47f9-97e6-3f5f1761caa7)

![16](https://github.com/user-attachments/assets/cde4ae2d-7507-48d3-afc8-0fb4139c631a)
