> [!IMPORTANT]
> The HTML content of Email messages has a maximum size limit of 128 KB, which includes all HTML text, styles, comments, and embedded graphics (but not anchored external graphics). If the HTML content exceeds this limit, then you'll still be able to go live with the email, but you won't be able to go live with any customer journey that includes that email; instead, the journey will always return a validation error on the relevant email tile saying: “Internal error: the email is still syncing. Please try again later.”
> 
> When you go live with a message, [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] processes the HTML content to create inline styles, compress spaces, and more, so it can be hard to know the exact final size of the message. If you have a messages that you suspect violates the HTML size limit, then do the following:
> 
> 1. Open a web browser and enter a URL of the form:   `https://<your_domain>/api/data/v9.0/msdyncrm_marketingemails(<email_id>)`  
> Where:
>    - _&lt;your_domain&gt;_ is the root of your [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] instance (such as "contoso.crm.dynamics.com").
>    - _&lt;email_id&gt;_ is the ID for the message you want to check. To find this ID, open the message in [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] and find the value of the `id=` parameter shown in your browser's address bar.
> 1. Search for the value of the field "msdyncrm_emailbody" in the returned JSON.
> 1. Copy the value of that field into a text program that can tell you the exact size of the HTML content.