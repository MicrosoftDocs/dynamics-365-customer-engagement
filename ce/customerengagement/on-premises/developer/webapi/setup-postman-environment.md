---
title: "Set up a Postman environment (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Learn how to set up and configure a Postman environment that connects with Dynamics 365 Customer Engagement online and on-premises environments."
ms.custom: 
ms.date: 04/15/2019
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 955BA444-A53D-4843-9429-833B1636E2B4
caps.latest.revision: 7
author: phecke
ms.author: pehecke
manager: shujoshi
search.audienceType: 
  - developer

---

# Set up a Postman environment

You can use Postman to connect to your [!INCLUDE[](../../includes/pn-dyn-365.md)] for Customer Engagement (on-premises) instance and to compose Web API requests, send them, and view responses. Managing authentication challenges many people. This topic describes how to configure a Postman environment to work for both online and on-premises environments.

You can use a Postman environment to save a set of variables that you use to connect. These values can be accessed within Postman by using this syntax: `{{name}}`. [!INCLUDE[](../../includes/sdk-for-more-info-about.md)] Postman variables, see [Postman Documentation > Variables](https://www.getpostman.com/docs/v6/postman/environments_and_globals/variables).

> [!NOTE]
> [!INCLUDE[](../includes/cc-cdsnote-2-topic.md)]
>
> The documentation that is applicable to Dynamics 365 Customer Engagement app (online) users is now available in the Power Apps documentation at: [Set up a Postman environment](/powerapps/developer/common-data-service/webapi/setup-postman-environment).

## Prerequisites

* Have an online or on-premises environment you can connect to. 
* Download and install the [Postman desktop application](https://www.getpostman.com/apps).

Select the connection option that works for your environment: 

* [Connect with an online environment](#bkmk_connectonline)
* [Connect with an on-premises environment](#bkmk_connectonpremise)

<a name="bkmk_connectonline"></a> 

## Connect with an online environment

To connect with an online environment, see the information provided in this Power Apps Dataverse topic: [Connect with an online environment](/powerapps/developer/common-data-service/webapi/setup-postman-environment#connect-with-your-common-data-service-environment).

<a name="bkmk_connectonpremise"></a>

## Connect with an on-premises environment

1. Launch the Postman desktop application.
2. Select the **Environment Options** gear icon in the top-right corner. 
3. In the **Manage Environments** dialog box, select the **Add** button to add a new environment.
4. In the dialog box that opens, add a name for the environment. Then copy the following key-value pairs into the editing space.

  | Variable Name | Value |
  |----|---|
  |`url`|`https://yourservername/yourorgname`|
  |`version`|`9.1`|
  |`webapiurl`|`{{url}}/api/data/v{{version}}/`|

  ![Create a new Postman environment to connect with On-premise instance](../media/postman-add-onprem-env.png "Create a new Postman   environment to connect with On-premise instance")

5. Replace the instance URL placeholder value with your Dynamics 365 Customer Engagement (on-premises) instance URL, and select **Add** to save the environment.
6. Close the **Manage environments** dialog box.

### Set credentials

1. On the Authorization tab, select **NTLM Authentication [Beta]**.
1. Set the following values in the form:<br>
•	**Username**.  Type the alias only; do not include the domain.<br>
•	**Password**. You have the option to show the password.<br>
•	**Domain**. You must set this if you are accessing the account from a different domain, although you can set it to **~** so that the default domain of the server is used.<br>

Your authentication might look like this if you are logging in as an administrator.<br>

![Click on Authorization tab, and select NTLM Authentication](../media/postman-ntlm-auth.png "Click on Authorization tab, and select NTLM Authentication")



## Test your connection

Create a new Web API request to test the connection with your Dynamics 365 Customer Engagement (on-premises) instance. Use the <xref href="Microsoft.Dynamics.CRM.WhoAmI?text=WhoAmI function" />:
1. Select `GET` as the HTTP method and add `{{webapiurl}}WhoAmI` in the editing space.
  ![WhoAmI function request](../media/postman-whoami-request.png "WhoAmI function request")
2. Select **Send** to send this request.
3. If your request is successful, you see the data from the <xref href="Microsoft.Dynamics.CRM.WhoAmIResponse?text=WhoAmIResponse ComplexType" /> that is returned by the <xref href="Microsoft.Dynamics.CRM.WhoAmI?text=WhoAmI Function" />.

## See also

[Use the Dynamics 365 Customer Engagement Web API](../use-microsoft-dynamics-365-web-api.md)<br>
[Walkthrough: Register a Dynamics 365 Customer Engagement app with Active Directory](../walkthrough-register-app-active-directory.md)


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]