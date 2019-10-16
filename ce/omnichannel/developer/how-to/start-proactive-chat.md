---
title: "Start chat proactively | Microsoft Docs"
description: "Read how you can start chat proactively to see if customers need help and thereby improve customer experience"
keywords: ""
ms.date: 10/16/2019
ms.service: dynamics-365-customerservice
ms.custom:
ms.topic: reference
applies_to:
ms.assetid: B8E99BB8-302D-4197-96FA-C8963A9560AB
author: susikka
ms.author: susikka
manager: shujoshi
---
# Start chat proactively

Anticipating areas where customers need help and then engaging them through chat when they have been browsing your website for some time helps improve customer satisfaction.

Consider the scenarios given below for initiating chat proactively.

## Scenario 1: Customer wait time

Amy has accidentally damaged her Surface Book and is on the product knowledge base trying to seek answers for about 20 seconds. She is then offered a proactive chat.

A chat pop-up is triggered based on the product page that Amy is browsing and the time spent on the page.

Here is the chat invitation message that is sent.

```
Hi! Just checking in to see if I can help answer any questions you may have. 
```

Amy can accept the chat offer and start the conversation to sort out her issue. 

### Sample code

```html
<!-- Code to show proactive chat invite after visitor has spend given time on the webpage -->
<script id="Proactivechattrigger">
	// Wait for Chat widget to load completely
    window.addEventListener("lcw:ready", function handleLivechatReadyEvent(){
		var timeToWaitBeforeOfferingProactiveChatInMilliseconds = 20000;//time to wait before Offering proactive chat to web page visitor
		// setting Context variables
        Microsoft.Omnichannel.LiveChatWidget.SDK.setContextProvider(function contextProvider(){
            return {
                'Proactive Chat':{'value':'True','isDisplayable':true},
                'Time On Page':{'value': timeToWaitBeforeOfferingProactiveChat ,'isDisplayable':true},
                'Page URL':{'value': window.location.href,'isDisplayable':true},
            };
        });
		
		//show proactive chat invite after 'timeToWaitBeforeOfferingProactiveChatInMilliseconds' milliseconds
        setTimeout(function(){
            Microsoft.Omnichannel.LiveChatWidget.SDK.startProactiveChat({message: "Hi! Just checking in to see if I can help answer any questions you may have."}, false)
        },timeToWaitBeforeOfferingProactiveChatInMilliseconds);
    });
</script>
```

## Scenario 2: Customer browsing multiple webpages

Thomas is browsing through the Microsoft Surface community webpage. He is looking for answers of his question on Microsoft Surface device. He has browsed through multiple pages but is not able to find the answers he is looking for.

Realizing this scenario, the organization offers a chat request to the customer with the message given below.

```
Hi! Do you have a question on Surface device ? I am here to help.
```
### Sample code

```html
<!-- Code to show proactive chat invite( after given time) after visitor visits the webpage given number of time -->

<!-- Operations on cookies like creating cookies, deleting cookies etc.. -->
<script>
var expdate = new Date ();
expdate.setTime (expdate.getTime() + (24 * 60 * 60 * 1000*365)); // 1 yr from now 
/* ####################### start set cookie  ####################### */
function setCookie(name, value, expires, path, domain, secure) {
  var thisCookie = name + "=" + escape(value) +
      ((expires) ? "; expires=" + expires.toGMTString() : "") +
      ((path) ? "; path=" + path : "") +
      ((domain) ? "; domain=" + domain : "") +
      ((secure) ? "; secure" : "");
  document.cookie = thisCookie;
}

/* ####################### start get cookie value ####################### */
function getCookieVal (offset) {
  var endstr = document.cookie.indexOf (";", offset);
  if (endstr == -1)
    endstr = document.cookie.length;
  return unescape(document.cookie.substring(offset, endstr));
/* ####################### end get cookie value ####################### */
}

/* ####################### start get cookie (name) ####################### */
function GetCookie (name) {
  var arg = name + "=";
  var alen = arg.length;
  var clen = document.cookie.length;
  var i = 0;
  while (i < clen) {
    var j = i + alen;
    if (document.cookie.substring(i, j) == arg)
      return getCookieVal (j);
    i = document.cookie.indexOf(" ", i) + 1;
    if (i == 0) break; 
  }
  return null;
}
/* ####################### End get cookie (name) ####################### */

/* ####################### Start delete cookie ####################### */
function DeleteCookie (name,path,domain) {
  if (GetCookie(name)) {
    document.cookie = name + "=" +
      ((path) ? "; path=" + path : "") +
      ((domain) ? "; domain=" + domain : "") +
      "; expires=Thu, 01-Jan-70 00:00:01 GMT";
  }
}
/* ####################### End of delete cookie ####################### */

/* ####################### Count number of visits to current webpage ####################### */
function VisitCounter(){
var visits = GetCookie("timesPageVisited");
if (!visits) { visits = 1; 
document.write("Select a Conversation Space");
} 
else { 
visits = parseInt(visits) + 1;document.write("Select a Conversation Space.");}
setCookie("timesPageVisited", visits,expdate);
}
/* ####################### End of count number of visits to current webpage ####################### */
</script>


<!-- Count number of visits to current webpage -->
<script>
VisitCounter();
</script>

<script id="Proactivechattrigger">
	// Wait for Chat widget to load completely
    window.addEventListener("lcw:ready", function handleLivechatReadyEvent(){
		// setting Context variables
        Microsoft.Omnichannel.LiveChatWidget.SDK.setContextProvider(function contextProvider(){
            return {
                'Proactive Chat':{'value':'True','isDisplayable':true},
                'No. of visits':{'value':'2','isDisplayable':true},
                'Forums':{'value':'Surface Devices','isDisplayable':true},
            };
        });

        setTimeout(function(){
			var timeToWaitBeforeOfferingProactiveChatInMilliseconds = 5000;//Time to wait before offering proactive chat to web page visitor
            var visits = GetCookie("timesPageVisited");
			//Check if webpage has been visited 2 or more times by the user.
            if (visits > 2) {		
				//Display proactive chat invite
                Microsoft.Omnichannel.LiveChatWidget.SDK.startProactiveChat({message: "Hi! Do you have a question on Surface device? I am here to help."}, false);
                DeleteCookie("timesPageVisited");//Delete the cookie to reset the counter
            }
        },timeToWaitBeforeOfferingProactiveChatInMilliseconds);
    });
</script>

```

## Scenario 3: Customer checking status for support case

Jacob is browsing through the support page for Microsoft Surface devices to find some more information regarding his open support case.

On realizing that Jacob has visited the support page seeking more information regarding his open case, he is offered proactive chat with the message given below.

```
Hi! How are you doing today? The status of the case:<caseid> is in progress. Would you like to get more details?
```

### Sample code

```html
<!-- Code to show proactive chat invite after visitor has spend given time on the webpage, with relavant details about user. -->
<script id="Proactivechattrigger">
	// Wait for Chat widget to load completely
    window.addEventListener("lcw:ready", function handleLivechatReadyEvent(){
		var timeToWaitBeforeOfferingProactiveChatInMilliseconds = 10000;//Time to wait before offering proactive chat to web page visitor
		var caseId = '< your case id relevant to the user.>';//Set case id relevant to the user.
		// setting Context variables
        Microsoft.Omnichannel.LiveChatWidget.SDK.setContextProvider(function contextProvider(){
            return {
                'Proactive Chat':{'value':'True','isDisplayable':true},
                'Case Id':{'value':caseId,'isDisplayable':true}
            };
        });
		
		//Show proactive chat invite after 'timeToWaitBeforeOfferingProactiveChatInMilliseconds' milliseconds
        setTimeout(function(){
            Microsoft.Omnichannel.LiveChatWidget.SDK.startProactiveChat({message: "Hi! How are you doing today? The status of the case: " + caseId + " is in progress. Would you like to get more details?"}, false)
        },timeToWaitBeforeOfferingProactiveChatInMilliseconds);
    });
</script>
```

## See also

[startProactiveChat API](reference/methods/startProactiveChat.md)<br />
[Manage custom context](send-context-starting-chat.md)<br />
[Initiate a chat](initiate-chat-wait-time.md)<br />
[Display custom context](display-custom-context.md)<br />
[Live chat JavaScript API reference](../omnichannel-reference.md)