---
title: "Create chat authentication settings | MicrosoftDocs"
description: "Instructions to create chat authentication settings in Omnichannel for Customer Service."
author: lalexms
ms.author: laalexan
manager: shujoshi
ms.date: 12/03/2020
ms.topic: article
ms.service: dynamics-365-customerservice
---

# Create chat authentication settings

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

You can create authentication settings to validate a signed-in customer from a domain, and extract information based on the context variables that are defined. You can differentiate your anonymous customers from authenticated customers, and you can create rules based on the context variables.

For example, you can have separate queues for anonymous customers and authenticated customers. Because you have more information about your authenticated customers, you can also prioritize them based on specific variables, such as shopping cart value or a privileged status.

After you create an authentication settings record, you must add it in the **Basic details** tab of the appropriate chat widget to make it work.

An agent will get a notification in the **Conversation summary** section whether a customer is authenticated or not. The **Authenticated** field is set to **Yes** or **No** based on the authentication of the customer. If a chat widget does not have any authentication setting associated with it, **Authenticated** field is set to **No** even if a customer is logged in to the portal. For information on conversation summary, see [Conversation summary](oc-customer-summary.md#conversation-summary).

## Prerequisites

Make sure your organization has a working knowledge of Oauth 2.0 and JSON Web Tokens (JWTs). 

## Create a chat authentication setting record

1. In the site map of Omnichannel admin center app, select **Customer settings**, and then select **Manage** for **Authentication settings** Omnichannel Administration. If you're using the Omnichannel Administration app, go to **Authentication Settings** under **Settings**.

    A list of existing authentication settings is shown.

3. Select **New** to add an authentication settings record.
4. On the **New Chat Authentication Settings** page, provide the following information:

    - **Name**: Enter a name for the authentication setting.
    - **Owner:** Accept the default value or change to a required value.
    - **Authentication type:** By default, it is OAuth 2.0 implicit flow that can't be edited.
    - **Public key URL**: Specify the public key URL of the domain. This URL is used to validate the information that comes in from the JavaScript Object Notation (JSON) Web Token (JWT) of the domain that a customer has signed in to.
    - **JavaScript client function**: Specify the JavaScript client function to use for authentication. This function extracts a token from the token endpoint.

        > [!div class=mx-imgBorder]
        > ![Create chat authentication setting record](media/chat-auth-settings.png "Create chat authentication setting record")

    For more information about how to find the public key URL and JavaScript client function, see the [Setup for Power Apps portals](#setup-for-power-apps-portals) section or the [Setup for custom portals that are not created using Power Apps](#setup-for-custom-portals-that-are-not-created-using-power-apps) section later in this topic.

5. Select **Save**.

## Add authentication to chat widget

1. Open the chat widget to which you want to add authentication and do one of the following steps:
   - In Omnichannel admin center, go to the Behaviors tab. 
   - In Omnichannel Administration, go to the **Basic details** tab.
2.	In the **Authentication settings** box, browse and select the chat authentication record.

When a signed-in customer on a portal opens the chat widget, the JavaScript client function passes the JWT from the client to the server. The JWT is decrypted and validated by using the public key, and the information is then passed to the chat agent in Omnichannel for Customer Service. As an admin, you can also pass additional information about the signed-in customer in the JWT by defining custom context variables. The context variables must be defined exactly as they are defined in the work stream that is associated with the chat widget.

## Setup for Power Apps portals

If you're adding authentication for a chat widget on a website developed using Power Apps portals, the public key URL, JavaScript client function, and JWT are available out of the box. Here is how you can get the required values:

- **Public key URL**: `<portal_base_URL>/_services/auth/publickey`
- **JavaScript client function**: `auth.getAuthenticationToken`
- **Token endpoint**: `<portal_base_URL>/_services/auth/token`

## Setup for custom portals that are not created using Power Apps

If you are adding an authenticated chat experience to a custom website, your web development team will need to do some initial set up before your administrators can configure authenticated chat. 

1. Generate a public/private key pair in their authentication servers. The keys must be generated using RSA256. 

    Here is sample code for generating private/public key pairs.

    ```Powershell
    openssl genpkey -algorithm RSA -out private_key.pem -pkeyopt rsa_keygen_bits:2048
    openssl rsa -pubout -in private_key.pem -out public_key.pem
    ```

2. Create an endpoint that will return your public keys. The public keys will be used by the Omnichannel servers to validate the JWT token passed as a part of authorizing the chat request. The URL of this endpoint will be entered into the Omnichannel Administration app when creating an Authentication setting record.  

    Your public key endpoint will look similar to this example:

        -----BEGIN PUBLIC KEY----- 
        NIIBIjANBgkqhkiG9w0BAQEFABCOPQ8AMIIBCgKCAQEAn+BjbrY5yhSpLjcV3seP 
        mNvAvtQ/zLwkjCbpc8c0xVUOzEdH8tq4fPi/X5P/Uf2CJomWjdOf1wffmOZjFasx 
        ELG+poTqy5uX2dNhH6lOMUsV31QGG36skLivpLBCSK6lWlzsV6WGkb/m8r86aGzp 
        jtNhw8yvoTYB4updDrJ8pC+tx4EWK0WEmKn1GsW6TjUtxJjcTLI1puSbmcGHbkSi 
        RSbWkKPqaEVFALprw+W5ZCung5QX3KOkY/rJd+2JwULm7okyQCQaF7qwa5i9Uf65 
        7M6ZL4vsDevq7E/v3tf6qxpSSHzt4XspXVQty9QHhqDqBEY3PfI4L2JjgIGuPhfS 
        YQIDAQAB 
        -----END PUBLIC KEY-----   
        
    If you need to use multiple public keys, your public key endpoint can return a set of `<kid, publickey >` pairs. (Note that key ID pairs must be unique.)  The kid will need to be passed in the JWT token in step 4. If you are using multiple keys, your public key endpoint should return something that looks like this. Note that the public key is base 64 encoded: 
        
        [
        { 
          "kid": "aYO4EaKT1xYU9JCoqALz6YURr41BqL0Hqp4in6hu4=", 
          "publicKey": "LS0tLS1CRUdJTiBQVUJMSUMgS0VZLS0tLS0NCk1JSUJJakFOQmdrcWhraUc5dzBCQVFFRkFBT0NBUThBTUlJQkNnS0NBUUVBbjFLdXhtSEh3V3hjelZABCDEFmMNCnBEaFZwa0FnYklhTGZBUWc1bFpvemZqc29vcWRGWkl0VlFMdmRERWFVeDNqTytrTkxZM0JFRnBYVDZTN3ZNZCsNCnZoM2hpMDNsQ1dINnNCTWtaSWtuUUliMnFpekFsT0diU2EvK3JrUElnYnpXQjRpT1QyWVhyOVB4bXR5d2o4WUINCnYram55VU5DSzMyZy9FYWsvM0k3YW1vZ2pJY0JISjNFTjVuQWJBMExVVnJwMW5DODJmeEVPOHNJTzNYdjlWNVUNCnc5QnVTVVFRSmtMejNQYVI5WTdRZUEyNW5LUGtqTXZ2Y0UxVU5oeVpIYlNLbmorSitkZmFjb1hsSGtyMEdGTXYNCldkSDZqR0pWcGNQMHBkNjFOa3JKa2c0aStheThwS2ZqdjNUOHN3NWdaVHFweFFaaitVRWxqaVM0SHRPTlhkNlENCnZRSURBUUFCDQotLS0tLUVORCBQVUJMSUMgS0VZLS0tLS0NCg==" 
        }, 
        { 
          "kid": "tYL4NaKT1xRO8WCoqALv6DCVr41MqL0Hqp4ik7hu5=", 
          "publicKey": "YJ0tLS1CRUdJTiBQVUJMSUMgS0VZLS0tPO0NCk1JSUJJakFOQmdrcBhraUc5dzBCQVFFRkFBT0KBUThBTUlJQkNnS0NBUUVBbjFLdXhtSEh3V3hjelZSWGRBVmMNCnBEaFZwa0FnYklhTGZBUWc1bFpvemZqc29vcWRGWkl0VlFMdmRERWFVeDNqTytrTkxZM0JFRnBYVDZTN3ZNZCsNCnZoM2hpMDNsQ1dINnNCTWtaSWtuUUliMnFpekFsT0diU2EvK3JrUElnYnpXQjRpT1QyWVhyOVB4bXR5d2o4WUINCnYram55VU5DSzMyZy9FYWsvM0k3YW1vZ2pJY0JISjNFTjVuQWJBMExVVnJwMW5DODJmeEVPOHNJTzNYdjlWNVUNCnc5QnABCDEFmtMejNQYVI5WTdRZUEyNW5LUGtqTXZ2Y0UxVU5oeVpIYlNLbmorSitkZmFjb1hsSGtyMEdGTXYNCldkSDZqR0pWcGNHJKEFNjFOa3JKa2c0aStheThwS2ZqdjBEHUF3NWdaVHFweCCaaitERWxqaVM0SHRPTlhkNlENCnZRSURBUUFCDQotLS0tLUVORCBQVUJMSUMgS0VZLS0tQM0NCg==" 
        } 
        ] 

        
3. You will need a service that generates the JWT to send to Omnichannel’s servers as a part of starting a chat for an authenticated user.  

    a. The JWT header will look similar to this example: 
       
    ```JavaScript
    { 
      "alg": "RS256", 
      "typ": "JWT", 
    } 
    ```

    If you are using multiple public keys, you will need to pass in the key id (kid). Your header will look similar to this example:

    ```JavaScript
    { 
      "alg": "RS256", 
      "typ": "JWT",
      "kid": "qWO4EaKT1xRO7JC/oqALz6DCVr41B/qL0Hqp4in7hu4="
    } 
    ```

   b. The JWT payload should include the following: 

     - At minimum, these claims: 

          | Claim | Definition |
          |-------|-------------------------------------------------------------------------------------------------------------|
          | Iss   | The issuer of the token. |
          | Iat   | The date the token was issued. This is in numeric date format.  |
          | Exp   | The expiration date of this token. Beyond this date it is no longer valid. This is in numeric date format.  |
          | Sub   | The subject of the claim. (We recommend using the GUID of the contact or account record in CRM.)  |

     - The lwicontext(s): the context variables to pass in as a part of the conversation, either for routing purposes or to display to the agent. To learn more about lwicontexts, see [Manage custom context](send-context-starting-chat.md).
     
     - Any other data you wish to pass. 

        Your payload will look similar to this example: 

          ```JavaScript
          { 

            "sub" : "87b4d06c-abc2-e811-a9b0-000d3a10e09e", 
            "preferred_username" : "a184fade-d7d0-40e5-9c33-97478491d352", 
            "phone_number" : "1234567", 
            "given_name" : "Bert", 
            "family_name" : "Hair", 
            "email" : "admin@contosohelp.com", 
            "lwicontexts" :"{\"msdyn_cartvalue\":\"10000\", \"msdyn_isvip\":\"false\", \"portalcontactid\":\"87b4d06c-abc2-e811-a9b0-000d3a10e09e\"}", 
            "iat" : 1542622071, 
            "iss" : "contosohelp.com", 
            "exp" : 1542625672, 
            "nbf" : 1542622072 
          } 
          ```     
        
    c. The JWT signature should be signed by your private key. 

      > [!NOTE]
      > - If the token is expired or invalid, the chat widget will throw an error event. 
      > - The setContextProvider method does not need to be used for authenticated chat. You should pass in your lwicontexts as a part of the JWT payload.

4. Create a javascript function on your website that will accept a callback function and return a JWT to the callback function. To avoid timeout, this javascript function should return a JWT within 10 seconds. This JWT will: 

    - Contain the header, payload, and signature from Step 3. 

    - Be signed by the private key from the key pair in step 1. 

      We recommend that you generate your JWT on your web server. 

      The name of this javascript method will be used to create the Authentication settings record in the Omnichannel Administration app. 

        ```JavaScript
        // This is a sample javascript client function  

        auth.getAuthenticationToken = function(callback){ 

          var xhttp = new XMLHttpRequest(); 
          xhttp.onreadystatechange = function() { 
              if (this.readyState == 4 && this.status == 200) { 
                  callback(xhttp.responseText); 
              } 
          }; 
          xhttp.onerror = function(error) { 
              callback(null); 
          }; 
        //Replace this with a call to your token generating service 
          xhttp.open("GET", "https://contosohelp.com/token", true); 
          xhttp.send(); 
        } 
        ```

5. Your developer will need to share the following information with your Omnichannel administrator: 

    a. The URL of the public key service from step 2.  
       
      Example: https://www.contoso.com/auth/publickey 

    b. The name of the javascript client function from step 4. This will be called internally by the live chat widget during the start of a chat. 
       
      Example: auth.getAuthenticationToken 

    > [!NOTE]
    > If your user experience exposes the chat button before users are authenticated, make sure to redirect them to your authentication page as needed. This can be done in the method in step 4, or as an earlier step in your user flow. 

    This diagram walks through the setup:
    
   > [!div class=mx-imgBorder]
   > ![Authenticated chat setup](media/auth-chat-setup.png "Authenticated chat setup")

    Then, you can set up authenticated chat by following these steps: 

6. Go to the Omnichannel admin center or Omnichannel Administration app, and create an authentication settings record with the information from step 5. See [Create a chat authentication setting record](create-chat-auth-settings.md#create-a-chat-authentication-setting-record) for more information. 

7. Associate the authentication settings to the chat widget that will have an authenticated experience. See [Add authentication to chat widget](create-chat-auth-settings.md#add-authentication-to-chat-widget) for more information. 

    This diagram walks through the call sequence when a user accesses your chat in an authenticated setup:

     > [!div class=mx-imgBorder]
     > ![Authenticated chat runtime](media/auth-chat-runtime.png "Authenticated chat runtime")


### See also

[Add a chat widget](add-chat-widget.md) <br>
[Configure a pre-chat survey](configure-pre-chat-survey.md) <br>
[Create quick replies](create-quick-replies.md) <br>
[Create and manage operating hours](create-operating-hours.md) <br>
[Embed chat widget in Power Apps portals](embed-chat-widget-portal.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]