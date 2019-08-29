# Weblog
This application is a weblog (blog) application. The intention of this project is to be a "live" project that can be used for coding practice, much like katas.  Hopefully having a live project with a broader scope will allow the owner to:
* Practice multiple aspects of software development (i.e. data objects, storage repositories, UI, unit tests, integration tests, etc.).
* Have working code that can be used to test software upgrades or migrations.
* Practice breaking work into small, deployable chunks.
* Experience software deployment and maintenance in a prod-like environment.

# To Do
- [X] Design data model and repository.
- [X] Design URL endpoints.
- [ ] Create in-memory test of API. (like Postman)
- [X] Create POST endpoint to create a blog entry.
- [X] Create GET endpoint to get a blog entry.
- [ ] UI Spike.
    - [X] Determine technology to use (probably Angular, but worth looking at Vue.js).
    - [X] Install Angular: https://angular.io/guide/setup-local
      - [X] Install Angular:  npm install -g @angular/cli
    - [ ] Tour of Heroes
      - [X] Create base application
      - [ ] Pick Up at: Master/Detail
    - [ ] Create workspace:  ng new weblog 
    - [ ] Lay out Post creation UI.
    - [ ] Lay out Post viewing UI.
- [ ] Create Post creation UI.
- [ ] Create Post viewing UI.
- [ ] Create data store.
- [ ] Create repository to hit data store.

# Design Considerations
This is just my design scratch pad to get started.
## Data Model
Post
  ID
  DateCreated
  Content
  Author
  Title
  Tags
  Comments

Comment
  ID
  PostID
  DateCreated
  Author
  Title
  Content

Author
    ID
    FirstName
    LastName
    UserName (?)

Tag
  ID
  Title

## URL Endpoints
weblog/api/v1/posts GET

weblog/api/v1/posts/{ID}    GET PUT POST

weblog/api/v1/posts/{ID}/comments   GET

weblog/api/v1/posts/{ID}/comments/{ID}  GET PUT POST

# Future Considerations
* Support comments.
* Support markdown syntax in post creation.
* Explore storage possibilities.
  * CosmosDB
  * Azure Blog Storage
  * Files in a git repo

