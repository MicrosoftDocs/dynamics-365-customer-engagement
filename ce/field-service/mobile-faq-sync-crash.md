---
title: "My mobile app will not sync to the server or it crashes immediately Dynamics 365 for Field Service | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 10/03/2018
ms.reviewer: ""
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.technology: 
  - "field-service"
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: krbjoran
ms.assetid: f7e513fc-047f-4a88-ab83-76fae5e583e2
caps.latest.revision: 42
ms.author: FieldServiceDave
manager: shellyha
search.audienceType: 
  - admin
  - customizer
search.app: 
  - D365CE
  - D365FS
---
# My mobile app will not sync to the server or it crashes immediately

There are multiple reasons a user may not be able to sync his mobile application to the server or why the application crashes immediately.

1) Incorrect URL, username, or password. **This is the most common reason**.

2)  There is no mobile project in Woodford, or the mobile project is unpublished

3)  The mobile project is published to a later version than the mobile app

4)  Your user does not have the correct security role to access the mobile application

### 1) Incorrect URL, username, or password. **This is the most common reason**. 

Edit the URL, username, and password in Setup. Note the username and password are case sensitive.

![Mobile FAQs image6](media/Mobile-FAQs-image6.png)  

### 2) There is no mobile project in Woodford, or the mobile project is unpublished

To fix this, in a non-private Internet Explorer browser as an administrator, navigate to **Settings > Woodford > MobileCRM Woodford** and verify a mobile project exists. A blue circle indicates it is published.

![Mobile FAQs image3](media/Mobile-FAQs-image3.png)

![Mobile FAQs image7](media/Mobile-FAQs-image7.png)

**If no mobile project exists**, download and save the template file.

-   If you are on December 2016 Update for Dynamics 365 (online), use this [mobile project template](https://go.microsoft.com/fwlink/p/?linkid=836310)  

-   If you are on Dynamics CRM Online 2016 Update 1, use this [mobile project template](http://go.microsoft.com/fwlink/p/?LinkId=808250)  

>[!Note]
> **Hint:** You may need to save the template file to a file location on your computer and not the Downloads folder.

Next, import this file into Woodford

![Mobile FAQs image8](media/Mobile-FAQs-image8.png)  

And assign it a name, a priority greater than 0, and assign it to all Field Service security roles

![Mobile FAQs image9](media/Mobile-FAQs-image9.png)  

More details on projects and priorities can be found in the [Woodford Guide](https://www.resco.net/downloads/Woodford_Guide.pdf).  

Finally, double click on the project (template) to view it.

Select **Publish**

### 3) The mobile project is published to a later version than the mobile app

Example: if you are using mobile app version 9.1 but your mobile project in Woodford is published to 9.2+ or the latest.

This results in the “Unsupported metadata version” error

![Mobile FAQs image10](media/Mobile-FAQs-image10.png)  

To fix this, first check the version of your mobile app in the About section

![Mobile FAQs image1](media/Mobile-FAQs-image1.png)

Next, to view your Woodford solution version, in a non-private Internet Explorer navigate to **Settings > Woodford > MobileCRM Woodford**

![Mobile FAQs image3](media/Mobile-FAQs-image3.png)

And then enter the related mobile project and ensure it is not published to a higher version. In the picture below the mobile project is published to 9.1 which does not exceed the version of our Field Service Mobile (2017) app.

![Mobile FAQs image5](media/Mobile-FAQs-image5.png)

### 4) Your user does not have the correct security role to access the mobile application

When an administrator of the mobile application sets up Woodford, he/she must assign a set of security roles to a mobile project (default configurations). This decides which users get access to the customizations of the project. If a user logs into the mobile app and does not have a security role that corresponds to a published mobile project, the user will not be able to sync to the server.

In a non-private Internet Explorer browser, navigate to **Settings > Woodford MobileCRM Woodford **

![Mobile FAQs image3](media/Mobile-FAQs-image3.png)  

Select and highlight the mobile project your mobile users should have access to and select **Show Users**

![Mobile FAQs image11](media/Mobile-FAQs-image11.png)  

![Mobile FAQs image12](media/Mobile-FAQs-image12.png)  

If the user who cannot sync is not shown here, then he/she does not have access to the mobile project and will not be able to connect.

To fix this, select the mobile project and select **properties** in the header to view security roles who have access to the mobile project

![Mobile FAQs image13](media/Mobile-FAQs-image13.png)  

Then, match the selected security roles above with the user’s security roles in **D365 > Settings > Security > Users**

