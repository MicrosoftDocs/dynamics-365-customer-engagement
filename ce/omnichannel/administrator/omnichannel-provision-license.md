---
title: "Provision Omnichannel for Customer Service | MicrosoftDocs"
description: "See how you can provision Omnichannel for Customer Service"
keywords: "Provision Omnichannel for Customer Service"
ms.date: 07/22/2019
ms.service:
  - "dynamics-365-customerservice"
ms.custom:
  - ""
ms.topic: article
ms.assetid: dcb07f11-106d-4368-87e9-015da0999f06
author: anjgupta
ms.author: anjgup
manager: shujoshi
---

# Provision Omnichannel for Customer Service

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

Omnichannel for Customer Service provides a modern, customizable, high-productivity app that lets agents help customers across different channels via a unified interface. It lets organizations choose the channel that suits their business needs. It also ensures that a high level of responsive, quality service is received across channels.

> [!NOTE]
> Before you can provision Omnichannel for Customer Service in your organization, a **Global Tenant Admin** must [Provide data access consent](#provide-data-access-consent). </br> </br> Ensure that all the prerequisites are set up before the app is provisioned. More information, see [Prerequisites](../system-requirements-omnichannel.md#prerequisites). 

Looking for an upgrade? See [Upgrade Omnichannel for Customer Service](upgrade-omnichannel.md) for more information.

## Provide data access consent

To allow Omnichannel for Customer Service to read and write data on behalf of users, follow these below steps:

1. Go to [Data access consent URL](https://go.microsoft.com/fwlink/?linkid=2070932).
2. Sign in using **Global Tenant Admin** credentials.
3. Select the checkbox **Consent on behalf of your organization**.
4. Select **Accept** to grant data access consent.

    > [!div class=mx-imgBorder]
    > ![Grant consent](../media/data-consent.png)


## Provision Omnichannel for Customer Service application

> [!IMPORTANT]
> Ensure that you are either a **Global Tenant Admin** or **Dynamics 365 Service Admin** of your org to be able to provision the Omnichannel for Customer Service application.

### Set up Omnichannel for Customer Service

> [!NOTE]
> Ensure that you have provided data access consent before you proceed with the setup. For more information, see [Provide data access consent](#provide-data-access-consent).

1. In the **Dynamics 365 Administration Center**, got to the **Applications** tab, select **Omnichannel for Customer Service**, and then select **Manage**.
      
    > [!div class=mx-imgBorder]
    > ![Manage omnichannel](../media/manage-oc.png)

    The **Manage Omnichannel Instances** page is displayed.

    > [!NOTE]
    > The Omnichannel for Customer Service option will appear only if you have an active subscription of Chat for Dynamics 365 Customer Service. For more information on pricing, click [here](https://dynamics.microsoft.com/en-us/customer-service/overview/#pricing). You can also get a free 30-day trial if you have the required perquisites, see [Try Chat for Dynamics 365 Customer Service](../try-chat-for-dynamics365.md) for more information.

2. On the **Manage Omnichannel Instances** page, select **Add Org** to add an organization. Omnichannel is set up on the organization instance that you add here.
   
    > [!div class=mx-imgBorder]
    > ![manage instances](../media/manage-instances.png)

    > [!IMPORTANT]
    > As an admin, you can configure Omnichannel on multiple environment (instances). You can view the status of all organization instances where the Omnichannel app has been configured in the **Manage Instances** view.

3. Select the organization in the **Organization Selector** drop-down list. 

    > [!div class=mx-imgBorder]
    > ![select org](../media/select-org.png)

    > [!IMPORTANT]
    > You must select the check box for **Privacy terms**, and proceed with the set up.
      
    Select the continue arrow ![Continue terms](../media/continue-arrow.png) to proceed.

4. On the **Enable Chat with Omnichannel** page, select the check box to enable the Chat channel for your organization. To proceed with the setup, select the Continue arrow.

    > [!div class=mx-imgBorder]
    > ![Enable chat](../media/enable-chat.png)

5. On the **Enable SMS with Omnichannel** page, select the **Select to enable SMS in your organization** check box to enable the SMS channel, and to proceed with the setup, select the continue arrow.

    > [!div class=mx-imgBorder]
    > ![Enable SMS with Omnichannel](../media/enable-sms-with-omnichannel.png "Enable SMS with Omnichannel")

    > [!IMPORTANT]
    > You must select the check box for **SMS Terms** to enable SMS and proceed with the setup.

6. On the **Enable Facebook Messenger with Omnichannel** page, select the **Select to enable Facebook Messenger in your organization** check box to enable the Facebook Messenger channel, and to proceed with the setup, select the continue arrow.

    > [!div class=mx-imgBorder]
    > ![Enable Facebook Messenger with Omnichannel](../media/enable-facebook.png "Enable Facebook Messenger with Omnichannel")

    > [!IMPORTANT]
    > You must select the check box for **Preview Terms** to enable Facebook Messenger and proceed with the setup.
    
7. On the **Summary** page, select the check mark icon to provision Omnichannel in your organization.

    The setup can take few mins. You may close the window and check after some time, or refresh to check if it's complete. Once the setup is complete, the selected channels are enabled in your environment.

    ![Summary tab on Manage Omnichannel instances page](../media/manage-omnichannel-summary.png "Summary tab on Manage Omnichannel instances page")
    
    The organization and the enabled channels are also available in the **Manage Instances** view.

    > [!div class=mx-imgBorder]
    > ![Set up complete](../media/install-complete.png)

### See also

[Upgrade Omnichannel for Customer Service](upgrade-omnichannel.md)

[Understand and create work streams](work-streams-introduction.md)

[Manage users](users-user-profiles.md)
