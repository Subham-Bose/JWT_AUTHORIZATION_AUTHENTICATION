# 🔐 Simple JWT Authentication API with .NET

This is a minimal implementation of **JWT-based authentication** in a **.NET Web API** using a hardcoded user list. It includes a single login endpoint that issues a JWT upon successful authentication.

## 🎯 Purpose

A starter project demonstrating:
- Basic JWT token creation in .NET
- Authentication of users from a static list
- Role-based claims inside the token
- Token generation using HMAC SHA256

---

## 🚀 Features

- Stateless authentication using JWT
- Role claims included in the token
- Token expiration configuration
- Minimal setup (no database or registration)

---

## 📁 Project Structure
JWTAuthApi/
│
├── Controllers/
│ └── LoginController.cs
├── Models/
│ └── UserConstants.cs
│ └── UserLogin.cs
| └── UserModel
├── Program.cs
├── appsettings.json

---

## 🧪 Example User List

The user list is defined in `UserConstants.cs`:

```csharp
public class UserConstants
{
    public static List<UserModel> Users = new()
    {
        new UserModel() {Username = "Test", Password = "Test", Role = "Test"}
    };
}
```

📄 License
This project is licensed under the MIT License.

🙋‍♂️ Contribution
Feel free to fork and enhance the following:

Database integration

Registration and password hashing

Refresh tokens

Middleware for token validation
