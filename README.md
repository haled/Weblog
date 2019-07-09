# Weblog
This application is a weblog (blog) application. The intention of this project is to be a "live" project that can be used for coding practice, much like katas.  Hopefully having a live project with a broader scope will allow the owner to:
* Practice multiple aspects of software development (i.e. data objects, storage repositories, UI, unit tests, integration tests, etc.).
* Have working code that can be used to test software upgrades or migrations.
* Practice breaking work into small, deployable chunks.
* Experience software deployment and maintenance in a prod-like environment.

# To Do
1. Design data model and repository.
1. Design URL endpoints.
1. Create POST endpoint to create a blog entry.
1. Create GET endpoint to create a blog entry.
1. UI Spike.
    1. Determine technology to use (probably Angular, but worth looking at Vue.js).
    1. Lay out Post creation UI.
    1. Lay out Post viewing UI.
1. Create Post creation UI.
1. Create Post viewing UI.

# Future Considerations
* Support comments.
* Support markdown syntax in post creation.
* Explore storage possibilities.
  * CosmosDB
  * Azure Blog Storage
  * Files in a git repo

# Wild Exploration
* Git interaction with Jupyter notebooks
    * can blog posts be saved as Jupyter notebooks in git and rendered?
    * Get "post"
    * Save "post"
    * Render "post"
    * would probably need some kind of menu and catalog system for the posts
    * could be an interesting research tool
* Markdown mixed with interactive C# (code) gists
* Alternate set of methods
    * Get catalog
    * get post
    * create post
    * render post (in UI)
    * data model
        * CatalogItem
            * Title
            * Date
            * Author
            * Content
            * ItemType
            * IsPublic?
            * SupportsComments
            * CommentList
        * Catalog
            * List of CatalogItems
        * ItemType
            * Post
            * Comment
        * User
            * Name
            * ID
            * Privileges
