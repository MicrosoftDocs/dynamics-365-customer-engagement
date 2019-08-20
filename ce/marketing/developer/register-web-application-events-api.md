---
title: "Register your web application to use Events API (Dynamics 365 for Marketing Developer Guide) | MicrosoftDocs"
description: "Read about the Events API that lets you access data of events, sessions, session tracks and passes"
ms.custom: 
  - dyn365-developer
  - dyn365-marketing
ms.date: 06/12/2019
ms.service: dynamics-365-marketing
ms.technology: 
  - marketing
ms.topic: conceptual
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
ms.assetid: BE033FC0-72E1-4DBC-B35B-A5A67682A9DE
author: susikka
ms.author: susikka
manager: shujoshi
search.audienceType: 
  - developer
search.app: 
  - D365CE
  - D365Mktg
---
# Register your web application to use Events API

To use the Events API, you need to provide a web application token in each request. The web application token is used to control API requests that are associated with your organization. Follow the steps given below to register your web application:

1. Open your Dynamics 365 instance and navigate to **Event Management**.
2. Click on the dropdown and select **Settings**

    ![Settings](../media/event-management-settings.png "Settings")
    
3. Click on the **Web applications**
    
    ![Web application token](../media/create-we-application-token.png "Web application token")
    
4. Click on the **New** to create a new web application token.
5. Enter details in the **Name** field.
6. For the **Origin** field enter the  URL from where your application is served in the **Primary endpoint** value that you got while enabling the static website. For example: `http://localhost:4200` or `https://contoso.com`.

   ![Web application token details](../media/enter-web-application-token-details.png "Web application token details")
   
   > [!NOTE]
   > When you enter the Primary endpoint value, make sure that you don't have a trailing slash (/) at the end of the url.
   
7. Click on **Save**. You will get the web application token and the API endpoint. 

## See also

[Using Events API](using-events-api.md)