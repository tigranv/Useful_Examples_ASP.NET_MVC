# ASP.NET [State Managment](https://msdn.microsoft.com/en-us/library/75x4ha6s.aspx) <img src="https://cloud.githubusercontent.com/assets/24522089/24391421/08a39e1e-13a0-11e7-85af-51c0f5f76a6a.png" align="right" width="200px" height="180px" /> 

State management is the process by which you maintain state and page information over multiple requests for the same or different pages. As is true for any HTTP-based technology, Web Forms pages are stateless, which means that they do not automatically indicate whether the requests in a sequence are all from the same client or even whether a single browser instance is still actively viewing a page or site. Furthermore, pages are destroyed and re-created with each round trip to the server; therefore, page information will not exist beyond the life cycle of a single page.
ASP.NET provides multiple ways to maintain state between server round trips. Which of these options you choose depends heavily upon your application, and it should be based on the following criteria:

* How much information do you need to store?
* Does the client accept persistent or in-memory cookies?
* Do you want to store the information on the client or on the server?
* Is the information sensitive?
* What performance and bandwidth criteria do you have for your application?
* What are the capabilities of the browsers and devices that you are targeting?
* Do you need to store information per user?
* How long do you need to store the information?
* Do you have a Web farm (multiple servers), a Web garden (multiple processes on one machine), or a single process that serves the application?


## Client-Side State Management Options

Storing page information using client-side options doesn't use server resources. These options typically have minimal security but fast server performance because the demand on server resources is modest. However, because you must send information to the client for it to be stored, there is a practical limit on how much information you can store this way.

The following are the client-side state management options that ASP.NET supports:

> **View state**

> **Cookies**

> **Query strings**

### View State

Web Forms pages provide the ViewState property as a built-in structure for automatically retaining values between multiple requests for the same page. View state is maintained as a hidden field in the page.You can use view state to store your own page-specific values across round trips when the page posts back to itself. For example, if your application is maintaining user-specific information — that is, information that is used in the page but is not necessarily part of any control — you can store it in view state.

> **Advantages of using view state are:**

* **No server resources are required**   The view state is contained in a structure within the page code.
* **Simple implementation**   View state does not require any custom programming to use. It is on by default to maintain state data on controls.
* **Enhanced security features**   The values in view state are hashed, compressed, and encoded for Unicode implementations, which provides more security than using hidden fields.

> **Disadvantages of using view state are:**

* **Performance considerations**   Because the view state is stored in the page itself, storing large values can cause the page to slow down when users display it and when they post it. This is especially relevant for mobile devices, where bandwidth is often a limitation.
* **Device limitations**   Mobile devices might not have the memory capacity to store a large amount of view-state data.
* **Potential security risks**   The view state is stored in one or more hidden fields on the page. Although view state stores data in a hashed format, it can still be tampered with. The information in the hidden field can be seen if the page output source is viewed directly, creating a potential security issue.


### Cookies

Cookies are useful for storing small amounts of frequently changed information on the client. The information is sent with the request to the server.

> **Advantages of using cookies are:**

* **Configurable expiration rules**   The cookie can expire when the browser session ends, or it can exist indefinitely on the client computer, subject to the expiration rules on the client.
* **No server resources are required**   The cookie is stored on the client and read by the server after a post.
* **Simplicity**   The cookie is a lightweight, text-based structure with simple key-value pairs.
* **Data persistence**   Although the durability of the cookie on a client computer is subject to cookie expiration processes on the client and user intervention, cookies are generally the most durable form of data persistence on the client.

> **Disadvantages of using cookies are:**
* **Size limitations**   Most browsers place a 4096-byte limit on the size of a cookie, although support for 8192-byte cookies is becoming more common in newer browser and client-device versions.
* **User-configured refusal**   Some users disable their browser or client device's ability to receive cookies, thereby limiting this functionality.
* **Potential security risks**   Cookies are subject to tampering. Users can manipulate cookies on their computer, which can potentially cause a security risk or cause the application that is dependent on the cookie to fail. Also, although cookies are only accessible by the domain that sent them to the client, hackers have historically found ways to access cookies from other domains on a user's computer. You can manually encrypt and decrypt cookies, but it requires extra coding and can affect application performance because of the time that is required for encryption and decryption. 

### Query Strings

A query string is information that is appended to the end of a page URL. You can use a query string to submit data back to your page or to another page through the URL. Query strings provide a simple but limited way of maintaining some state information. For example, query strings are an easy way to pass information from one page to another, such as passing a product number to another page where it will be processed

> **Advantages of using query strings are:**
* **No server resources are required**   The query string is contained in the HTTP request for a specific URL.
* **Widespread support**   Almost all browsers and client devices support using query strings to pass values.
* **Simple implementation**   ASP.NET provides full support for the query-string method, including methods of reading query strings using the Params property of the HttpRequest object.

> **Disadvantages of using query strings are:**

* **Potential security risks**   The information in the query string is directly visible to the user via the browser's user interface. A user can bookmark the URL or send the URL to other users, thereby passing the information in the query string along with it. If you are concerned about any sensitive data in the query string, consider using hidden fields in a form that uses POST instead of using query strings

## Server-Side State Management Options

Server-side options for storing page information typically have higher security than client-side options, but they can use more Web server resources, which can lead to scalability issues when the size of the information store is large. ASP.NET provides several options to implement server-side state management.

The following are the server-side state management options that ASP.NET supports:

> **Application state**

> **Session state**

> This project written on C# 6.0, .NET Framework 4.6 Visual Studio 2015 Comunity Edition

