---
title: "Email Configuration for Administrators | Microsoft Docs"
description: "Email Configuration for Administrators"
ms.date: 08/03/2020
ms.service:
  - "dynamics-365-customerservice"
ms.topic: article
author: lerobbin
ms.author: lerobbin
manager: shujoshi
---

# Configure Email 

Email is a critical communication tool that allows users to interact with customers in a timely and effect manner. The Dynamics 365 Customer Service email experience provides an easy and immersive rich text email experience for users that helps them deliver a more professional and consistent personalized service in an efficient and effective manner using templates and enhanced features and functionality.  

This experience gives system administrators the ability to configure email templates and enable quick access to email to help users create emails fast directly from the timeline so they can deliver a more personalized service.

How to navigate email configurations
- [How to enable email]()
- [How to enable the enhanced email experience]()
- [How to configure email attachments size limitations]()
- [How to configure email attachment displays]()
- [How to enable inline attachment functionality on customized forms]()
- [How to enable email templates]()

## How to enable email
Email must be enabled for users to view and access it. Unless email is enabled it will not display in the command bars.

To enable email:
1.	Go to **Settings**
2.	Go to **Advanced Settings**
3.	Go to **Settings**
4.	Go to **Customizations**
5.	Go to **Customize the System**
6.	Expand **Entities**, select and expand **Email**, select **Forms**
7.	From the command bar, select **Form Order** and a dropdown list will appear
8.	Select **Main Form Set**
9.	The **Form Order** display window will appear showing all email forms that have been enabled to be available is displayed in this window. Both the **Navigate** to and **Contextual** (pop-up) email experience work off the same form order. 
10.	If **Enhanced email** is not displaying at the top of the list, use the arrows to move it up so that displays first on the list.
11.	Select **OK**
12.	You must **Publish All Customizations** for changes to appear otherwise they will not display.

![How to enable email](media\email-how-to-enable-email-1.png "How to enable email")
![How to enable email](media\email-how-to-enable-email-2.png "How to enable email")
![How to enable email](media\email-how-to-enable-email-3.png "How to enable email")
![How to enable email](media\email-how-to-enable-email-4.png "How to enable email")
![How to enable email](media\email-how-to-enable-email-5.png "How to enable email")

## How to enable the enhanced email experience
Enhanced email is the default setting, but you must enable email for users to access and use the feature. 

Sign into https://<YourOrgURL>.dynamics.com/apps and open model-driven app then:
1.	Go to **Settings**
2.	Select **Advanced Settings**
3.	Select **Settings**
4.	Select **Administration** 
5.	Select **System Settings**
6.	Select the **Email** tab
7.	To enable pop-up email windows, click the box in **Enhanced email for Timeline** section. 
8.	Select **OK** to save your global organizational setting and close.

![How to enable the enhanced email experience](media\email-how-to-enable-email-1.png "How to enable the enhanced email experience")

![How to enable the enhanced email experience](media\email-how-to-enable-the-enhanced-email-experience-1.png "How to enable the enhanced email experience")

![How to enable the enhanced email experience](media\email-how-to-enable-the-enhanced-email-experience-2.png "How to enable the enhanced email experience")

![How to enable the enhanced email experience](media\email-how-to-enable-the-enhanced-email-experience-3.png "How to enable the enhanced email experience")

## How to configure email attachment size limitations
You can manage file size limits for emails on file attachments. 

To manage email attachment size limitations, use the following steps: 
1.	Under **System Settings** go to Email
2.	Under the **Set file size limit for attachments** section you can set file size on attachments. 

> [!Note] 
> The default file size limit for attachments is 5MB.  The size limit for attachments can be increased to a maximum of 132MB per file. 

![How to configure email attachment size limitations](media\email-how-to-configure-email-attachment-size-limitations-1.png "How to configure email attachment size limitations")


### See Also

[Email FAQs](email-faqs.md)
