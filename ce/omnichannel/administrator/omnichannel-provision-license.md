---
title: "Provision Omnichannel for Customer Service | MicrosoftDocs"
description: "See how you can provision Omnichannel for Customer Service"
author: sbmjais
ms.author: shjais
manager: shujoshi
ms.date: 12/13/2019
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: article
---

# Provision Omnichannel for Customer Service

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

Omnichannel for Customer Service provides a modern, customizable, high-productivity app that lets agents help customers across different channels via a unified interface. It lets organizations choose the channel that suits their business needs. It also ensures that a high level of responsive, quality service is received across channels.

> [!NOTE]
> - Before you can provision Omnichannel for Customer Service in your organization, a **Global Tenant Admin** must [Provide data access consent](#provide-data-access-consent).
> - Ensure that all the prerequisites are set up before the app is provisioned. More information, see [Prerequisites](../system-requirements-omnichannel.md#prerequisites). 

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

1. In **Dynamics 365 Administration Center**, go to the **Applications** tab, select **Omnichannel for Customer Service**, and then select **Manage**.
      
    > [!div class=mx-imgBorder]
    > ![Manage omnichannel](../media/manage-oc.png)

    The **Manage Omnichannel Instances** page is displayed.

    > [!NOTE]
    > The Omnichannel for Customer Service option will appear only if you have an active subscription of Chat for Dynamics 365 Customer Service or Dynamics 365 Digital Messaging. For more information on pricing, click [here](https://dynamics.microsoft.com/en-us/customer-service/overview/#pricing). You can also get a free 30-day trial if you have the required prerequisites, see [Try channels for Dynamics 365 Customer Service](../try-channels.md) for more information.

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

4. On the **Enable chat with Omnichannel** page, select the check box to enable the Chat channel for your organization. To proceed with the setup, select the continue arrow.

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

7. On the **Summary** page, select the check mark icon to provision Omnichannel for Customer Service in your organization.

    The setup can take few mins. You may close the window and check after some time, or refresh to check if it's complete. Once the setup is complete, the selected channels are enabled in your environment.

    > [!div class=mx-imgBorder]
    > ![Summary tab on Manage Omnichannel instances page](../media/manage-omnichannel-summary.png "Summary tab on Manage Omnichannel instances page")
    
    The organization and the enabled channels are also available in the **Manage Instances** view.

    > [!div class=mx-imgBorder]
    > ![Set up complete](../media/install-complete.png)


## Update Omnichannel for Customer Service application

After Omnichannel for Customer Service application is successfully provisioned, you can update the instance by enabling or disabling the required channels.

1.	In **Dynamics 365 Administration Center**, go to the **Applications** tab, select **Omnichannel for Customer Service**, and then select **Manage**.
 
    > [!div class=mx-imgBorder]
    > ![Select Manage for Omnichannel for Customer Service](../media/update-oc.png "Select Manage for Omnichannel for Customer Service")

    The **Manage Omnichannel instances** page is displayed.

2.	On the **Manage Omnichannel instances** page, choose the instance you want to update. The summary of configured channels is displayed.

    > [!div class=mx-imgBorder]
    > ![Select the Omnichannel for Customer Service instance](../media/select-oc-instance.png "Select the Omnichannel for Customer Service instance")

3. Select the channel to be enabled. For example, in this procedure, we will enable the Facebook Messenger channel.

4. On the **Facebook** tab, select **Select to enable Facebook Messenger in your organization**.

    > [!div class=mx-imgBorder]
    > ![Enable Facebook Messenger channel](../media/enable-fb-channel.png "Enable Facebook Messenger channel")

5. If required, you can also disable the previously enabled channel. For example, in this procedure, we will disable the SMS channel. 

6. On the **SMS** tab, clear the **Select to enable SMS in your organization** and **SMS Terms** check boxes to disable the SMS channel. When you clear the **Select to enable SMS in your organization** check box, a confirmation message is displayed to remove the channel. Select **Remove**.

    > [!div class=mx-imgBorder]
    > ![Disable SMS channel](../media/disable-sms-channel.png "Disable SMS channel")

7. Select **Save** on the toolbar at the top of the page to start updating the instance.

8. Once the update is complete, the status is displayed on the **Summary** tab.

    > [!div class=mx-imgBorder]
    > ![Update status](../media/update-oc-complete.png "Update status")

> [!NOTE]
> If you disable all channels, Omnichannel for Customer Service will be removed from your organization.


### See also

[Upgrade Omnichannel for Customer Service](upgrade-omnichannel.md)<br>
[Understand and create work streams](work-streams-introduction.md)<br>
[Manage users](users-user-profiles.md)
