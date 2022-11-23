Here's a code sample that illustrates how you can pass an authentication token to an Azure or Power Virtual Agents bot during single sign-on.

```JavaScript
const signInIds = [];
window.Microsoft.Omnichannel.LiveChatWidget.SDK.setBotAuthTokenProvider(async (botTokenUrl, callback) => {
  const urlSearchParams = new URLSearchParams(botTokenUrl);
  const signInId = urlSearchParams.get("state");

  if (signInIds.includes(signInId)) { // Ignore authenticated sign-in cards
    callback({show: false});  // Hide card
    return;
  }

  signInIds.push(signInId);

  const authUrl = ""; // Customer's Authentication API
  const authResponse = await fetch(authUrl, method: "POST"});
  const {token} = authResponse;  // Customer's Auth Token

  const data = {
    token: "token"
  };

  const payload = {
    method: "POST",
    headers: {
      "Content-Type": "application/json"
    },
    body: JSON.stringify(data)
  };

  try {
    const botAuthResponse = await fetch(botTokenUrl, payload); // Posts Auth Token to Bot directly
    
    // Sign in through Bot is successful
    if (botAuthResponse.status === 200) {
      signInIds.push(signInId); // Track authenticated sign-in card
      callback({show: false}); // Hide card
    }

    if (botAuthResponse.status === 404 || botAuthResponse.status == 202) {
      callback({show: false}); // Hide card
      return;
    } else {
      // Other condition handling    
    }

    return;
  } catch (error) {
  
  }

  callback({show: true});  // Show sign-in card by default
});
```