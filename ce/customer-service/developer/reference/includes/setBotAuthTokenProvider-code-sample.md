Here's a code sample that illustrates how you can pass an authentication token to an Azure or Power Virtual Agents bot during single sign-on.

```JavaScript
Microsoft.Omnichannel.LiveChatWidget.SDK.setBotAuthTokenProvider(async (botTokenUrl, callback) => {
    const authUrl = ""; // Customer's Authentication API
    const authResponse = await fetch(authUrl, {method: "POST"});
    const { token } = authResponse;  // Customer's Auth Token
 
    const payload = {
       method: "POST",
       headers: {
         "Content-Type": "application/json"
       },
       token: token
    }
 
    const botAuthResponse = await fetch(botTokenUrl, payload); // Posts Auth Token to Bot directly
   
    // Sign in through Bot is successful
    if (botAuthResponse.status === 200) {
        // Hide sign in card
        callback({
           show: false
        });
    } else {
      // Other condition handling
    }
   
    // Show sign in card by default
    callback({
         show: true
    });
});
```