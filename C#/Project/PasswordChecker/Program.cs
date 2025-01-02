﻿// Password Checker
// This program will measure the strength of any given password 

  using System;

namespace PasswordChecker
{
  class Program
  {
    public static void Main(string[] args)
    {
        int minLength = 8;
        string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string lowercase = "abcdefghijklmnopqrstuvwxyz";
        string digits ="0123456789";
        string specialChars = "~!@#$%^&*-+";

        Console.Write("Enter a password: ");
        string password = Console.ReadLine();

        int score = 0;

        if(password == "password" || password == "1234") {
          score = 0;
        }else { 
        
            if(password.Length >= minLength) {
              score++;
            }

            if(Tools.Contains(password, uppercase)) {
              score++;
            }

            if(Tools.Contains(password, lowercase)) {
              score++;
            }

            if(Tools.Contains(password, digits)) {
              score++;
            }

            if(Tools.Contains(password, specialChars)) {
              score++;
            }
        }

        switch (score) {

          case 5:
          case 4:

          Console.WriteLine($"Your password scored a {score} that makes it an extremely strong password");
          break;

          case 3: 
          Console.WriteLine($"Your password scored a {score} that makes it a strong password");
          break;

          case 2:
          Console.WriteLine($"Your password scored a {score} that makes it a medium password");
          break;

          case 1:
          Console.WriteLine($"Your password scored a {score} that makes it a weak password");
          break;

          default:
          Console.WriteLine($"Your password scored a {score} so it doesn't meet any of the standards");
          break;
        }
 

    }
  }
}
