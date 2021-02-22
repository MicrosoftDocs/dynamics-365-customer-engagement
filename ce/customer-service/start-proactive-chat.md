---
title: "Start chat proactively | Microsoft Docs"
description: "Read how you can start chat proactively to see if customers need help and thereby improve customer experience"
author: v-sailab
ms.author: v-sailab
manager: shujoshi
ms.date: 04/06/2020
ms.topic: reference
ms.service: dynamics-365-customerservice
---
# Start chat proactively

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

Anticipating areas where customers need help and then engaging them through chat when they have been browsing your website for some time can help improve customer satisfaction.

Consider the scenarios given below for initiating chat proactively.

## Scenario 1: Customer wait time

Amy has accidentally damaged her Surface Book and is on the product knowledge base trying to seek answers for about 20 seconds. She is then offered a proactive chat.

A proactive chat request is triggered based on the product page that Amy is browsing and the time spent on the page.

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
		// Setting context variables
        Microsoft.Omnichannel.LiveChatWidget.SDK.setContextProvider(function contextProvider(){
            return {
                'Proactive Chat':{'value':'True','isDisplayable':true},
                'Time On Page':{'value': timeToWaitBeforeOfferingProactiveChatInMilliseconds ,'isDisplayable':true},
                'Page URL':{'value': window.location.href,'isDisplayable':true},
            };
        });
		
		//Display proactive chat invite after 'timeToWaitBeforeOfferingProactiveChatInMilliseconds' milliseconds
        setTimeout(function(){
            Microsoft.Omnichannel.LiveChatWidget.SDK.startProactiveChat({message: "Hi! Just checking in to see if I can help answer any questions you may have."}, false)
        },timeToWaitBeforeOfferingProactiveChatInMilliseconds);
    });
</script>
```

## Scenario 2: Customer visits a webpage multiple times

Thomas is browsing through the Microsoft Surface community webpage. He is looking for answers of his questions on Microsoft Surface device. He has visited a webpage mutliple times but he is not able to find the answers he is looking for.

Realizing this scenario, the organization offers a chat request to the customer after he has been waiting for some time on the current webpage, with the message given below.

```
Hi! Do you have a question on Surface device ? I am here to help.
```
### Sample code

```html
<!-- Code to show proactive chat invite(after given time) after visitor visits the webpage given number of time -->

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

Jacob is browsing through the support page for Microsoft Surface devices to find more information regarding his open support case.

On realizing that Jacob has visited the support page seeking more information regarding his open case and that he has been on the page for 10 seconds, he is offered a proactive chat with the message given below.

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

## Scenario 4: Customer tries to leave a webpage after spending some time on it

Amy has been browsing a webpage for 15 seconds and is not satisfied with the information provided on it. She is about to switch tabs on her web browser when she gets a chat request that asks her if she needs any help with her questions.

The proactive chat message is given below.

```
Hi! Just checking in to see if I can help answer any questions you may have.
```

### Sample code

```javascript
<!-- Code to show proactive chat invite when visitor tries to leave page after spending given time(15 seconds in this case) on the webpage. This invite is offered once and only for the first time. All subsequent tries to leave page are ignored and proactive chat is not offered in them. -->
<script id="Proactivechattrigger">
	//Track if proactive chat has been already offered to the visitor
	var hasProactiveChatBeenOffered = false;	
	//Wait for Chat widget to load completely
    window.addEventListener("lcw:ready", function handleLivechatReadyEvent(){
		var timeToWaitBeforeEnablingOfferingProactiveChatInMillisecondsOnLeaving = 15000; //Time to wait before Offering proactive chat to web page visitor
		
		//Enable showing proactive chat invite on leaving page after browsing page for 'timeToWaitBeforeEnablingOfferingProactiveChatInMillisecondsOnLeaving' milliseconds
        setTimeout(function(){
			//Show proactive chat invite on leaving page
			window.document.body.onmouseleave = function(){
				//Offer proactive chat if it has not been offered earlier during this visit
				if( hasProactiveChatBeenOffered == false )
				{
					// Set this to true as proactive chat has been almost offered.
					hasProactiveChatBeenOffered = true;
					//Setting Context variables
					Microsoft.Omnichannel.LiveChatWidget.SDK.setContextProvider(function contextProvider(){
						return {
							'Proactive Chat':{'value':'True','isDisplayable':true},
							'Page URL':{'value': window.location.href,'isDisplayable':true},
						};
					});
					//Offer proactive chat
					Microsoft.Omnichannel.LiveChatWidget.SDK.startProactiveChat({message: "Hi! Just checking in to see if I can help answer any questions you may have."}, false);
				}
			};
        },timeToWaitBeforeEnablingOfferingProactiveChatInMillisecondsOnLeaving);
    });
</script>
```

## Scenario 5: Customer coming from a specific webpage spends some time on the current webpage

Amy has browsed the FAQs document of the product and is currently on the Knowledge Base page for more than 15 seconds.

She is proactively offered chat with the message given below.

```
Hi! Just checking in to see if I can help answer any questions you may have.
```

### Sample code

```javascript
<!-- Code to show proactive chat invite when visitor spends given time on current page, after coming from given last visited page -->
<script id="Proactivechattrigger">
	var lastVisitedPage = "www.contoso.com/FAQ";// last visited page. A visitor coming form this page will be shown proactive chat invite after given time on current page
	// Wait for Chat widget to load completely
    window.addEventListener("lcw:ready", function handleLivechatReadyEvent(){
		var timeToWaitBeforeOfferingProactiveChat = 15000;//Time to wait before Offering proactive chat to web page visitor
		//Check if referrer page( read: https://www.w3schools.com/jsref/prop_doc_referrer.asp ) is same as last Visited page 
		if( window.document.referrer == lastVisitedPage) )
		{
			//Show proactive chat invite after browsing page for 'timeToWaitBeforeOfferingProactiveChat' milliseconds
			setTimeout(function(){
				//Setting Context variables
				Microsoft.Omnichannel.LiveChatWidget.SDK.setContextProvider(function contextProvider(){
				return {
							'Proactive Chat':{'value':'True','isDisplayable':true},
							'Page URL':{'value': window.location.href,'isDisplayable':true},
							'Last Page URL':{'value': window.document.referrer,'isDisplayable':true}
						};
				});
				//Offer proactive chat
				Microsoft.Omnichannel.LiveChatWidget.SDK.startProactiveChat({message: "Hi! Just checking in to see if I can help answer any questions you may have."}, false);
			},timeToWaitBeforeOfferingProactiveChat);
		}
    });
</script>
```

## Scenario 6: Customer logs in from a specific geographic region

Klarissa logs in to your website from Ruritania where your company is running a special discount on products. You can set up a trigger for customers coming from a particular location that proactively initiates chat.

Klarissa is prompted to chat with the message given below.

```
Hi! Just checking in to see if I can help answer any questions you may have.
```

### Sample code

This sample code shows how you can use Bing's Geolocation APIs to know the geographic region of the customer and offer chat request based on that. More information about Bing's location APIs: [Bing Maps Locations API](https://docs.microsoft.com/bingmaps/rest-services/locations/).

```javascript
<!-- Code to show proactive chat invite if visitor is visiting the page in a particular country or region -->
<script id="Proactivechattrigger">
	// Wait for Chat widget to load completely
    window.addEventListener("lcw:ready", function handleLivechatReadyEvent(){
		var countryNameWhereProactiveChatInviteShouldBeOffered = 'Ruritania';//Country name where proactive chat invite should be offered, if user is visiting webpage from this country
		
		// Get Country name using Bing Geolocation API and proactively offer chat if visitor's country matches with given country name
		function GetCountryUsingBingGeoLocationAPIAndOfferProactiveChatIfVisitorCountryMatchesWithGivenCountry( latitude, longitude, bingMapApiKey, countryToMatch) {
			var xhttp = new XMLHttpRequest();
			xhttp.onreadystatechange = function() {
			if (this.readyState == 4)
				if(this.status == 200) {
					console.log(this.responseText);
					var currentCountryName = JSON.parse(this.responseText).resourceSets[0].resources[0].address.countryRegion;
					//Check if visitor's country matches with given Country name
					if( currentCountryName == countryToMatch){
						alert(currentCountryName);
						// setting Context variables
						Microsoft.Omnichannel.LiveChatWidget.SDK.setContextProvider(function contextProvider(){
						    return {
						        'Proactive Chat':{'value':'True','isDisplayable':true},
						        'Country':{'value': currentCountryName ,'isDisplayable':true},
						        'Page URL':{'value': window.location.href,'isDisplayable':true},
						    };
						});
						//Show proactive chat invite
						Microsoft.Omnichannel.LiveChatWidget.SDK.startProactiveChat({message: "Hi! Just checking in to see if I can help answer any questions you may have."}, false);
					}
				}
				else{
					console.log("Bing Geolocation API call has failed and returned error: " + this.statusText);
				}
			};
			xhttp.open("GET", 'https://dev.virtualearth.net/REST/v1/Locations/'+ latitude +','+ longitude +'?key='+ bingMapApiKey, true);
			xhttp.setRequestHeader("Content-type", "application/json");
			xhttp.send();
		}
		
		//fetching latitude and longitude is success
		function successGetlatLong(position) {
			var latitude = position.coords.latitude;
			var longitude = position.coords.longitude;
			console.log('Your latitude is :'+latitude+' and longitude is '+longitude);
			//convert current loaction to a country/ region via Bing Geolocation APIs
			var bingMapApiKey = 'Enter your Bing Map API key';// Get Bing Map API key here : https://docs.microsoft.com/bingmaps/getting-started/bing-maps-dev-center-help/getting-a-bing-maps-key
			GetCountryUsingBingGeoLocationAPIAndOfferProactiveChatIfVisitorCountryMatchesWithGivenCountry( latitude, longitude, bingMapApiKey, countryNameWhereProactiveChatInviteShouldBeOffered);// get Country name using Bing Geolocation API and offer proctiveChat if visitor's country matches with Country name where proactive chat invite should be offered
		}
		
		//fetching latitude and longitude has failed
		function errorGetlatLong() {
			console.log('It seems browser was not allowed to access location. Please allow browser to access loaction.');
		}
		
		//fetch latitude and longitude via browser
		if (navigator.geolocation) {
			navigator.geolocation.getCurrentPosition(successGetlatLong, errorGetlatLong);
		} else {
			console.log('It seems like Geolocation, which is required for this page, is not enabled in your browser. Please use a browser which supports it.');
		}
    });
</script>
```

## Scenario 7: Proactively offer chat to customers between a certain time frame

Suppose your organization is running a festive season sale between certain dates, and you wish to proactively offer chat requests to customers to see if they have any questions.

### Sample code

The sample code given below shows how you can proactively offer chat invite to a customer if he/she visits your website between a given time period.

```javascript
<!-- Code to show proactive chat invite if visitor visits webpage between given time period -->
<script id="Proactivechattrigger">
	// Wait for Chat widget to load completely
    window.addEventListener("load", function handleLivechatReadyEvent(){//lcw:ready
		var startTimeOfTimePeriod = new Date('01 Jan 2019 00:00:00 GMT');//start time of time period in which proactive chat will be shown to web page visitor
		var endTimeOfTimePeriod = new Date('01 Jan 2100 00:00:00 GMT');//end time of time period in which proactive chat will be shown to web page visitor
		var currentDateTime = new Date();//current date and time
		
		//Make sure that endTimeOfTimePeriod is always greater and equal to startTimeOfTimePeriod
		if( endTimeOfTimePeriod < startTimeOfTimePeriod)
		{
			console.log("The time period given for proactive chat has start time: " + startTimeOfTimePeriod.toGMTString() + " more that the end time: " + endTimeOfTimePeriod.toGMTString() + " of time period. So, proactive chat will not be offered.");
			return;
		}
		
		//Check if current date time is between given time period
		if( startTimeOfTimePeriod < currentDateTime && endTimeOfTimePeriod > currentDateTime){
			// setting Context variables
			Microsoft.Omnichannel.LiveChatWidget.SDK.setContextProvider(function contextProvider(){
				return {
					'Proactive Chat':{'value':'True','isDisplayable':true},
					'Page URL':{'value': window.location.href,'isDisplayable':true},
				};
			});
			//Show proactive chat invite 
			Microsoft.Omnichannel.LiveChatWidget.SDK.startProactiveChat({message: "Hi! Just checking in to see if I can help answer any questions you may have."}, false);
		}
    });
</script>
```

## See also

[startProactiveChat API](developer/reference/methods/startProactiveChat.md)<br />
[Manage custom context](send-context-starting-chat.md)<br />
[Initiate a chat](initiate-chat-wait-time.md)<br />
[Display custom context](display-custom-context.md)<br />
[Live chat JavaScript API reference](developer/omnichannel-reference.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]