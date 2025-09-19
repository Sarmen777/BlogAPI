# Blog API

A simple REST API for managing Users, Blogs, Posts, Tags, and UserProfiles.  
Built with **ASP.NET Core 8 + EF Core + PostgreSQL** using **Repository + Service + DTO** patterns, with **Swagger** for API documentation and testing.

---

Running the Project

1. **Clone the repository**
```bash
git clone https://github.com/Sarmen777/BlogAPI.git
cd BlogAPI

2. **Configure database connection in appsettings.json**
"ConnectionStrings": {
  "DefaultConnection": "Host=localhost;Port=5432;Database=MyBlogDb;Username=postgres;Password=s100282s"
}

3. Apply migrations
dotnet ef database update

4. Run the API
dotnet run --project BlogAPI.PL

The API will be available at:

http://localhost:5155


Swagger Documentation

Access Swagger UI at:

http://localhost:5155/swagger/

Here you can explore and test all API endpoints.

Main API Endpoints
Users

GET /api/users — list users

GET /api/users/{id} — get user by Id

POST /api/users — create a new user

PUT /api/users/{id} — update a user

DELETE /api/users/{id} — delete a user

Blogs

GET /api/blogs — list blogs

GET /api/blogs/{id} — get blog by Id

POST /api/blogs — create a new blog

PUT /api/blogs/{id} — update a blog

DELETE /api/blogs/{id} — delete a blog

Posts

GET /api/posts — list posts

GET /api/posts/{id} — get post by Id

POST /api/posts — create a new post (requires existing BlogId)

PUT /api/posts/{id} — update a post

DELETE /api/posts/{id} — delete a post

Tags

GET /api/tags — list tags

GET /api/tags/{id} — get tag by Id

POST /api/tags — create a new tag

PUT /api/tags/{id} — update a tag

DELETE /api/tags/{id} — delete a tag

UserProfiles

GET /api/userprofiles — list profiles

GET /api/userprofiles/{id} — get profile by Id

POST /api/userprofiles — create a new profile

PUT /api/userprofiles/{id} — update a profile

DELETE /api/userprofiles/{id} — delete a profile

Technologies Used

.NET 8 / ASP.NET Core Web API

Entity Framework Core + PostgreSQL

AutoMapper for DTO mapping

Swagger / Swashbuckle

