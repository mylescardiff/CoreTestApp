<h1>Core Test App</h1>
<p style="color:red;"><b><u>First Step:</u></b> You will not be able to access the database in this app without sending me your IP address to white list it. Please send it with your name to: <a href="jobs@52Six.co">jobs@52Six.co</a></p>

<p>
    Here is a simple ASP.NET Core MVC application. Your task is to add a blog to this app.
    There are two Entity Framework Models in this application: BlogPost and BlogCategory. They need controllers and a way to view the blog.
</p>

<ol>
    <li>Clone this Git repo (https://github.com/mylescardiff/CoreTestApp.git)</li>
    <li>Create a new branch in the Git repository with your name on it, e.g. “john-smith” and checkout that branch</li>
    <li>Create a BlogPostsController and BlogCategoriesController with basic CRUD operations. You may use any helper tools Visual Studio comes with to do this.</li>
    <li>BlogPosts have a field called Content. That content should be HTML code. There is an example of a view using our HTML editor in ~/Views/Home/HtmlTest.cshtml. You will need to apply that to your BlogPosts/Create and Edit views so that the user can just type their blog content without knowledge of HTML.</li>
    <li>Make a View in the HomeController called “Blog” where all the blog posts are listed on one page, ordered by date with the newest blog post at the top.</li>
    <li>Create some sample blog posts and test your code. There might already be some posts and categories in the database, you can leave them in there.</li>
    <li>Create a pull request in Git with your finished code.</li>
</ol>
