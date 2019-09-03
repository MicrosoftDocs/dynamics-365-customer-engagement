---
title: "Try Chat for Dynamics 365 | MicrosoftDocs"
description: "Learn how you can try out Chat For Dynamics 365 to connect and engage with your customers in real time."
keywords: "try, Chat, Chat for Dynamics 365, Trials, sign in, sign-in, login"
ms.date: 08/27/2019
ms.service:
  - "dynamics-365-customerservice"
ms.custom:
  - ""
ms.topic: article
applies_to:
  - ""
ms.assetid: ebd41ac5-dd35-4451-9bd3-476e8d440246
author: sbmjais
ms.author: shjais
manager: shujoshi
---

# Try Chat for Dynamics 365

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

Chat for Dynamics 365 is an engagement channel that enables your agents to connect with customers in real-time. Chat can only be used if you have an active subscription of Dynamics 365 for Customer Service Enterprise or Dynamics 365 Customer Engagement Plan in your tenant.

There are two options to sign-up for a free 30-day trial of Chat:

1. [Chat trial through Microsoft 365 admin center](#option-1-chat-trial-through-microsoft-365-admin-center)
2. [Chat trial through trials.dynamics.com](#option-2-chat-trial-through-trialsdynamicscom)

## Option 1: Chat trial through Microsoft 365 admin center

With this option, you can sign-up for a free 30-day trial of Chat from the Microsoft 365 admin center only if you have a paid subscription of either Dynamics 365 for Customer Service Enterprise or Dynamics 365 Customer Engagement Plan that has been purchased directly through the Microsoft 365 admin center (that is, Web Direct channel). If you do not have one of these pre-requisite subscriptions, or if you have purchased these pre-requisite subscriptions through another channel then the option to try Chat will not be available in the Microsoft 365 admin center.

> [!NOTE]
> For more information on the Chat license, pricing and pre-requisites, please refer to the Dynamics 365 licensing guide [here](https://go.microsoft.com/fwlink/p/?LinkId=866544).

### Step 1: Get a trial subscription of Chat

1. Go to <https://portal.office.com> and sign in with the global administrator credentials. 

2. Go to **Billing** > **Purchase Services**, and select **Add-ons**. 

    ![Add-on subscriptions in Microsoft 365 admin center](media/add-on-subscriptions.png "Add-on subscriptions in Microsoft 365 admin center")

3. You'll see **Dynamics 365 for Customer Service Chat Trial** under **Add-on**. 
    
    ![Dynamics 365 for Customer Service Chat Trial option](media/chat-add-on.png "Dynamics 365 for Customer Service Chat Trial option")
    
    > [!IMPORTANT]
    > You must already have a paid license of either Customer Service Enterprise or Customer Engagement Plan in your tenant that was purchased directly through the Microsoft 365 admin center (that is, Web Direct channel), otherwise the **Dynamics 365 for Customer Service Chat Trial** option won't be visible.

4. You can start a 30-day trial of Chat with 25 user licenses.

5. After signing up for a trial, you must assign licenses of Chat to the users who need to engage with customers and provide support via Chat. This can be done by selecting one or more active users and editing their product licenses. After you're done, select **Save**.

    ![Product licenses dialog box](media/product-licenses-dialog-box.png "Product licenses dialog box")

### Step 2: Enable Chat in your organization

Once you have the subscription for Chat and assigned licenses to desired users, you can enable Chat in your organizations from Dynamics 365 Administration Center. 

In Dynamics 365 Administration Center, go to the **Applications** tab, select the **Omnichannel for Customer Service** application and select **Manage**. This will guide you to enable Chat on one or more instances that you may have. You can enable Chat on any instance type in this step. For more information on provisioning channels through the Dynamics 365 admin center, see [Provision Omnichannel for Customer Service](administrator/omnichannel-provision-license.md).

![Manage Omnichannel application](media/manage-oc-application.png "Manage Omnichannel application")

Once Chat is enabled in your organization, you can sign in to Dynamics 365 organization, and select the Omnichannel Administration application to start configuring Chat. For more information on configuring Chat in Dynamics 365, see [Configure a chat channel](administrator/set-up-chat-widget.md).

## Option 2: Chat trial through trials.dynamics.com

With this option, you can get a free 30-day trial of Chat through [https://trials.dynamics.com](https://trials.dynamics.com). You must have an existing organizational account and must be a global administrator to enable the trial. 

> [!NOTE]
> This option is currently available only in North America, Europe, Canada, and United Kingdom. Your tenant must be located in one of these regions. 

### Step 1: Get a Dynamics 365 trial instance

1. Go to <https://trials.dynamics.com>.

2. Select **Customer Service**. 

    > [!IMPORTANT]
    > Ensure that you select **Customer Service**. If you select any other option, Chat trial will not get enabled in your tenant.

3. Enter your work email and phone number, and then select **Get started**.

    ![Create a Customer Service trial](media/cs-trial.png "Create a Customer Service trial")

4. Sign-in with your global administrator credentials and accept the terms and privacy policy. The instance setup takes some time.

5. If you already have trial instances (Dynamics 365 instances with Instance Type set to Trial), you'll be asked to either join an existing organization or create your own trial. Select **Create your own trial** and then select **Create New Trial**. After that, select **Customer service** and then select **Complete Setup**.

   ![Create your own trial and complete setup](media/create-own-trial.png "Create your own trial and complete setup")

    > [!NOTE]
    > The maximum number of allowed trial instances in a tenant is five. If you already have five trial instances in your tenant, you must delete one instance before creating a new trial.

6.	If you are redirected to the applications page, select **Customer Service Hub** to open the application once it is setup.

7.	You will now be able to see the newly created instance in Dynamics 365 Administration Center under the **Instances** tab. The instance type will be set to Trial.

    ![New trial instance](media/new-trial-instance.png "New trial instance")

### Step 2: Get a Power BI (free) subscription

If you already have a subscription of Dynamics 365 Customer Engagement Plan or a subscription of Power BI in your tenant, you can skip this step. Otherwise, you must get a Power BI (free) subscription.

1. Go to <https://portal.office.com> and sign in with the global administrator credentials.
 
2. Go to **Billing** > **Purchase services**.
 
3. Search for Power BI (free) and complete the purchase of Power BI (free) subscription.

    ![Power BI (free) subscription](media/powerbi-free.png "Power BI (free) subscription")

### Step 3: Enable Chat in your organization

In Dynamics 365 Administration Center, go to the **Applications** tab, select the **Omnichannel for Customer Service** application and select **Manage**. This will guide you to enable Chat on one or more instances that you may have. You can enable Chat on any instance type in this step. For more information on provisioning channels through the Dynamics 365 admin center, see [Provision Omnichannel for Customer Service](administrator/omnichannel-provision-license.md).

![Manage Omnichannel application](media/manage-oc-application.png "Manage Omnichannel application")

Once Chat is enabled in your organization, you can sign in to Dynamics 365 organization, and select the Omnichannel Administration application to start configuring Chat. For more information on configuring Chat in Dynamics 365, see [Configure a chat channel](administrator/set-up-chat-widget.md).

### See also

[Provision Omnichannel for Customer Service](administrator/omnichannel-provision-license.md)  
[Configure a chat channel](administrator/set-up-chat-widget.md)
