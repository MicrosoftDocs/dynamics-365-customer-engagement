---
title: Provision Omni-channel Engagement Hub | MicrosoftDocs
description: See how you can provision omni-channel engagement hub
keywords: Provision Omni-channel Engagement Hub
author: anjgupta
ms.author: anjgup
manager: shujoshi
applies_to: 
ms.date: 2/8/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: dcb07f11-106d-4368-87e9-015da0999f06
ms.custom: 
---

# Provision Omni-channel Engagement Hub

Applies to Dynamics 365 for Customer Engagement apps version 9.1.0

[!include[cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

Omni-channel Engagement Hub provides a modern, customizable, high-productivity app that lets agents help customers across different channels via a unified interface. It lets organizations choose the channel that suits their business needs. It also ensures that a high level of responsive, quality service is received across channels.


> [!NOTE]
> Before you can provison Omni-channel Engagement Hub on your org, a **Global Tenant Admin** must [Allow sideloading of external apps in Microsoft Teams](#allow-sideloading-of-external-apps-in-microsoft-teams) and [Provide data access consent](#provide-data-access-consent). </br> </br> Ensure that all the pre-requisites are set up before the app is provisioned. For more information, see [Pre-requisites](../system-requirements-omni-channel-engagement-hub.md#pre-requisites).


## Allow sideloading of external apps in Microsoft Teams

To allow sideloading of external apps in Microsoft Teams, follow the below steps:

1. Go to [Microsoft 365 admin center](https://portal.office.com/adminportal/home#/homepage).
2. Select **Settings** > **Services & add-ins** > **Microsoft Teams**.
3. Expand **Apps** in **Tenant-wide settings**.
4. In the **External Apps** section, for the **Allow sideloading of external apps** option, switch the toggle button position to **On**.

For more information, see [Admin settings for apps in Microsoft Teams](https://docs.microsoft.com/en-us/microsoftteams/admin-settings).

## Provide data access consent

To allow Omni-channel Engagement Hub to read and write data on behalf of users, follow the below steps:

1. Go to [Data access consent URL](https://go.microsoft.com/fwlink/?linkid=2070932).
2. Login using **Global Tenant Admin** credentials.
3. Select the checkbox **Consent on behalf of your organization**.
4. Select **Accept** to grant data access consent.

    > [!div class=mx-imgBorder]
    > ![Grant consent](../media/data-consent.png)


## Provision Omni-channel Engagement Hub application

> [!IMPORTANT]
> Ensure that you are either a **Global Tenant Admin** or **Dynamics 365 Service Admin** of your Dynamics 365 org to be able to provision the Omni-channel Engagement Hub application.

### Step 1: Sign up for Omni-channel Engagement Hub preview

To get the Omni-channel Engagement Hub app, sign up for the Omni-channel Engagement Hub preview from the Insider portal.


1. Go to [Dynamics Insider Portal](http://experience.dynamics.com/insider) and log in with your Microsoft account.
2. Search for and open **Omni-channel Engagement Hub preview** in the **Upcoming and Active Public Preview Programs** list.

    > [!div class=mx-imgBorder]
    > ![Signup omni-channel](../media/preview-signup.png)

3. Select **Join now**. A preview survey is displayed.

    > [!div class=mx-imgBorder]
    > ![Fill survey for omni-channel](../media/preview-survey.png)

    Complete the survey to participate in the preview.

4. Fill in all the required fields. Provide the **Org ID** where you want to set up Omni-channel Engagement Hub. 

    > [!div class=mx-imgBorder]
    > ![Omni-channel org id](../media/preview-org.png)

    Select **Submit** to submit the survey.

    Once your request is approved, you will receive a confirmation email from Microsoft. Omni-channel Engagement Hub will be available in the org that you provided during the survey. You can view the app in **Manage applications** in the **Dynamics 365 Administration Center**.


### Step 2: Set up Omni-channel Engagement Hub

> [!NOTE]
> Ensure that you have allowed sideloading of external apps in Microsoft Teams and have provided data access consent before you proceed with the set up. For more information, see [Allow sideloading of external apps in Microsoft Teams](#allow-sideloading-of-external-apps-in-microsoft-teams) and [Provide data access consent](#provide-data-access-consent).

   1. In the **Dynamics 365 Administration Center**, select **Manage**.
      
        > [!div class=mx-imgBorder]
        > ![Manage omni-channel](../media/manage-oc.png)

       The **Manage Omni-channel Instances** page is displayed.

   3. On the **Manage Omni-channel Instances** page, select **Add Org** to add an organization. </br> Omni-channel is set up on the organization instance that you add here.
   
       > [!div class=mx-imgBorder]
       > ![manage instances](../media/manage-instances.png)

       > [!IMPORTANT]
       > As an admin, you can configure Omni-channel on multiple org instances. You can view the status of all org instances where the Omni-channel app has been configured in the **Manage Instances** view.

   3. Select the organization in the **Organization Selector** drop-down list. 

        > [!div class=mx-imgBorder]
        > ![select org](../media/select-org.png)

      You must select the checkboxes for **Microsoft Privacy Statement** and **Terms and Conditions** to accept the terms and proceed with the set up. You can read the privacy and preview conditions by selecting them in the **Terms & Conditions** section. 

        > [!div class=mx-imgBorder]
        > ![Preview terms](../media/preview-terms.png)
        
      Select **Close** to close the privacy and preview conditions. 

      Select the continue arrow ![Continue terms](../media/continue-arrow.png) to proceed.

   4. Select the check box to enable **Chat** channel on your org. 

       > [!div class=mx-imgBorder]
       > ![enable chat](../media/enable-chat.png)

   5. Select the check box to enable **SMS** channel on your org. 

       > [!div class=mx-imgBorder]
       > ![enable sms](../media/enable-sms.png)

       > [!NOTE]
       > You **must** select atleast one channel to proceed with the set up.
  
       Once the set up is completed successfully, you can see **Chat** and **SMS** channel enabled on the **Summary** page.

      > [!div class=mx-imgBorder]
      > ![summary of set up](../media/summary-fre.png)

On successful provisioning, you can view the org and the enabled channels in the **Manage Instances** view.

> [!div class=mx-imgBorder]
> ![Set up complete](../media/install-complete.png)


### See also

[Understand and create work streams](work-streams-introduction.md)

[Manage users](users-user-profiles.md)

