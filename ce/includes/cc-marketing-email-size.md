> [!IMPORTANT]
> You should limit the HTML content of email messages to a maximum size of 100KB. This size limit includes all HTML text, styles, comments, and embedded graphics (but not anchored external graphics). If the HTML content exceeds 128KB, you'll receive a size warning, but you can still go live with the email and any customer journey that includes the email.
> 
> When you go live with a message, [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] processes the HTML content to create inline styles, compress spaces, and more, so it can be hard to know the exact final size of the message. If you have a message that you suspect violates the HTML size limit, do the following:
> 
> 1. Open a web browser and enter a URL of the form:   `https://<your_domain>/api/data/v9.0/msdyncrm_marketingemails(<email_id>)`  
> Where:
>    - _&lt;your_domain&gt;_ is the root of your [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] instance (such as "contoso.crm.dynamics.com").
>    - _&lt;email_id&gt;_ is the ID for the message you want to check. To find this ID, open the message in [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] and find the value of the `id=` parameter shown in your browser's address bar.
> 1. Search for the value of the field "msdyncrm_emailbody" in the returned JSON.
> 1. Copy the value of that field into a text program that can tell you the exact size of the HTML content.