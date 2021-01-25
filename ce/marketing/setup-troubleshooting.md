---
title: "Administration and setup frequently asked questions (Dynamics 365 Marketing) | Microsoft Docs"
description: "Solutions to common questions and issues that can occur during the initial setup and ongoing administration of Dynamics 365 Marketing."
ms.date: 12/17/2020
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-admin
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
manager: shellyha
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Administration and setup FAQ

Read this article to find answers to common questions and solutions to known issues that can sometimes occur during the initial setup and ongoing administration of Dynamics 365 Marketing.

<a name="licensing"></a>

## How is Dynamics 365 Marketing licensed?

Dynamics 365 Marketing is licensed per instance, with each instance priced according to the number of marketing contacts stored in your database. Here are answers to several of the most frequently asked questions about licensing:

- **What is a marketing contact?**  
    Dynamics 365 Marketing is priced in relation to how many marketing contacts you have in your database, where a marketing contact is any contact used as part of a marketing activity in Dynamics 365 Marketing. Contacts that you don’t market to using Dynamics 365 Marketing features don’t count towards your marketing-contacts quota. Dynamics 365 Marketing keeps a detailed record of all the ways in which each contact interacts with your marketing initiatives, but monitors just a few key interaction types when it comes to identifying marketing contacts. Any contact that performs one or more of these key interactions will become flagged as a marketing contact, and therefore count against your quota. There are many other types of interactions (such as email opens, survey responses, and website visits) but these represent follow-up activities to the core set of key interactions. After a key interaction is logged for a contact, it doesn’t matter how many more of the same or follow-up interactions that contact performs, the contact is still counted just once. The key interaction types are:
  - Contact used in customer journey
  - Marketing email sent
  - Event check-in
  - Event registration
  - Marketing form submitted
  - LinkedIn form submission

- **Which marketing contacts count against my quota?**  
    All marketing contacts on your tenant are counted, regardless of instance type (including both production and non-production instances).

- **Where can I see my quotas and quota usage?**  
    To see how many of each quota you've purchased and used, go to **Settings** > **Advanced settings** > **Other settings** > **Quota limits**.

- **What is my monthly email quota?**  
    Your monthly email quota is equal to 10 times the number of marketing contacts you have purchased.

- **If I use a contact only once in a month and don’t use it next month, does it count?**  
    Marketing contacts are cumulative throughout your license period. Once you've engaged a contact in any marketing activity, that contact counts against your quota from that point forward. You can "true down" the number of marketing contacts you've purchased on the anniversary of your contract.

- **How can I learn more about Dynamics 365 Marketing licensing?**
  - For an overview, see [Purchase and set up Dynamics 365 Marketing](purchase-setup.md) 
  - For complete terms that apply to subscribed (paid) versions, download the [Microsoft Dynamics 365 Licensing Guide](https://go.microsoft.com/fwlink/p/?linkid=866544).
  - For trials, see [Dynamics 365 Marketing limits for trials](trial-preview-limits.md).
  - Check the [Readme](https://go.microsoft.com/fwlink/p/?linkid=864736) document for the latest news and updates.

<a name="incompatible-platform"></a>

## Why is my instance (organization) incompatible with Marketing?

Your tenant might have several different types of instances (also called *organizations*) installed on it, including some that are full Dynamics 365 instances and others that are, for example, Power Apps instances (also called *environments*) that include many components of Dynamics 365, but not all of the components required by Marketing.

When you are setting up your Marketing app, the setup wizard asks you to choose an organization on which to install the app, and the organization selector might show both full Dynamics 365 instances and the lighter Power Apps instances if they are present. You must choose an instance that includes a full Dynamics 365 installation. If you see an error telling you that *this application isn't compatible with the platform of your selected Dynamics 365 organization*, then make sure you have a full Dynamics 365 organization available (where you want to install Marketing) and choose that one instead.

<a name="register-apps-azure"></a>

## Do I have permissions to register applications on Azure?

One of the requirements for running the [setup wizard](purchase-setup.md) for Dynamics 365 Marketing is that you must sign in to Microsoft 365 with a user account that has permissions to register applications on Azure. To find out if you have these permissions, do the following:

1. Go to [portal.azure.com](https://portal.azure.com) and sign in with the Microsoft 365 account that you want to use to install Dynamics 365 Marketing.
1. Select **Azure Active Directory** under **Azure services**. On the next page, select **User settings** from the left side navigation.

    > [!div class="mx-imgBorder"]
    > ![Azure user settings](media/faq-azure-user-settings2.png)

1. Check the **App registrations** section on this page. If the **Yes** box is highlighted here, then you have permissions to register applications on Azure. If the **No** box is highlighted instead, try to select the **Yes** box and then select **Save**; if you don't have permissions to make this change, talk to your global administrator for assistance.

## Why do I get an authorization-failed message when I try to run the setup wizard?

In some cases, when you sign up for a trial of Dynamics 365 or Microsoft 365, you will receive an organization that is in an *unmanaged* state, which means (among other things) that you can't get permission to install third-party solutions&mdash;including Dynamics 365 Marketing. As a result, you'll see the following error message when you run the Marketing setup wizard.

![Unmanaged organization error](media/setup-ts-unmanaged-aad.png "Unmanaged organization error")

To fix this, do one of the following:

- If you are just setting up a trial of Marketing, then consider creating a new trial tenant and set up the Marketing trial there, as described in [Choose or prepare your Microsoft 365 tenant](trial-signup.md#choose-tenant).
- If you want to continue using the tenant where you received this error, then you must convert your unmanaged org into a managed one and then run the Marketing setup wizard again. For instructions on how to do this, see [Take over an unmanaged directory as administrator in Azure Active Directory](https://go.microsoft.com/fwlink/p/?linkid=866761).

<a name="run-fre"></a>

## How can I rerun the setup wizard?

If your setup fails for some reason, you'll be notified by email and/or by a status message in your web browser (if you keep it open during the installation). Often, part of the solution will be to rerun the setup wizard after waiting for an hour or so. To rerun the setup wizard, do one of the following:

- If you are setting up a [trial](trial-signup.md), you should have received a welcome email that included a link to the setup wizard. Find your welcome mail and select the link to launch the wizard.
- If you are setting up a production instance, then launch the setup wizard by going to **Resources** > **Dynamics 365 apps** in the Power Platform admin center, as described in [Re-run the Marketing setup wizard](re-run-setup.md).

<a name="fix-portal"></a>

## How can I fix occasional portal issues?

Marketing pages and the event website both run on Power Apps portals. Sometimes, you may notice that settings you make in Dynamics 365 Marketing aren't reflected on the portal right away, such as (for the event website): updates to banner images, speaker images, or payment gateway assignments&mdash;or, your portal may become unresponsive or otherwise unreliable. You can often solve all of these issues either by [clearing the portal cache](#portal-cache), or [restarting it](#restart-portal). It's faster to clear the cache, but restarting it will sometimes solve more or other issues.

<a name="portal-cache"></a>

### Clear the portal cache

You can solve many portal issues by clearing the portal cache. Once you have a portal user set up and configured as an administrator, this is faster and easier than [restarting the portal](#restart-portal), though some problem may still require a restart.

The subsections below explain how to set up the required portal user and then run the clear-cache command. If you already have a portal user that's configured as an administrator, just skip ahead to [Step 3: Clear the portal cache](#cache-only).

#### Step 1: Create an account on your portal

Start by adding yourself as a portal user, just as your contacts would do when registering themselves and others for an event (this is not the same as your Dynamics 365 user account). To do this:

1. Open your event website, for example by opening any event record and selecting the globe button next to the **Event URL** field.

1. On the event website, select the **Sign In** button at the top of the page.

1. On the sign-in page, go to the **Register** tab and fill out the fields to create a new account. You must use an email address that doesn&#39;t already belong to a contact in your database. Be sure to make a note of your user name and password.

1. The **Profile** page opens. Enter your first and last names in the fields provided and select **Update**.

1. Your account is now created.

#### Step 2: Grant your new account permission to clear the portals cache

Once you have your account and password set up, you must configure that account as an event-portal administrator. To do this:

1. Sign into Dynamics 365 Marketing and use the app selector to go to the Dynamics 365&mdash;custom app.

    > [!div class="mx-imgBorder"]
    > ![The app-selector menu](./media/nav-apps-custom.png)

1. In the custom app, go to the area selector menu in the lower left and select **Portals**. Then, in the left navigation pane, go to **Security** > **Contacts**.

1. The portal contacts page opens. Open the system-view selector menu and choose the **All Contacts** view.

    > [!div class="mx-imgBorder"]
    > ![The system-view selector](./media/faq-portal-system-views2.png)

1. Find your portal user in the list and open it.

1. Open the form-view selector and switch to the **Portal contact** form view.

    > [!div class="mx-imgBorder"]
    > ![Switch to the 'Portal contact' form view](./media/faq-portal-form-view2.png)

1. Go to the **Details** tab, then scroll down to the **Web Roles** section.

1. Select **Add Existing Web Role** to add a role, then select the magnifying glass icon to open the role menu, and finally select the **Administrators Event Portal** role to add that role to your contact.

    > [!div class="mx-imgBorder"]
    > ![Assign the admin role](./media/faq-portal-admin2.png)

1. Select the **Add** button in the bottom corner. Your user account is now an administrator for your event website.

<a name="cache-only"></a>

#### Step 3: Clear the portal cache

Once you have your portal-administration account set up, you can use it to clear the portal cache at any time. To do this:

1. Open your event website, for example by opening any event record and selecting the globe button next to the **Event URL** field.
1. On the event website, select the **Sign In** button at the top of the page.
1. Sign in as a user that you have set up as an event-portal administrator.
1. Enter the following URL:

     `https://<YourPortalDomain>/_services/about`

    Where `<YourPortalDomain>` is the domain of your portal. You can find it by looking at the URL shown when you signed into the portal.

1. A portal-administration page opens. Select **Clear cache**.

    ![Select the Clear cache button](media/faq-portal-clear-cache.png "Select the Clear cache button")

1. Your portal cache is cleared, which also has the effect of signing you out of the portal.

<a name="restart-portal"></a>

### Restart the portal

If clearing the cache didn't fix your portal issues, restarting it may help. This operation takes a bit longer than clearing cache, and your portal will be offline until the process is complete.

To restart your portal:

1. [Open the Power Platform admin center](power-platform-admin-center.md) and go to **Resources** > **Portals** on the left navigation pane.

2. Each configured portal app is listed using the name of the Dynamics 365 instance it is assigned to (so it probably doesn't have "portal" in its name), and shows a value of **Configured** in the **Status** column. Find and select your portal in the list and then select **Manage** in top navigation ribbon.  

    > [!div class="mx-imgBorder"]
    > ![Manage your portal](media/faq-portal-manage4.png)

3. The portals manager opens. Select **Portal actions** in the side panel, and then select the **Restart** tile to restart the portal. 

    ![Open portal actions and then select restart](media/faq-portal-manage2.png "Open portal actions and then select restart")

4. You'll be asked to confirm the action. Choose **Restart** to continue and then allow a few minutes for the process to complete.

<a name="portal-url"></a>

## How can I fix my portal after changing my instance name?

The Power Platform admin center enables you to change the  name of any of your instances at any time. If you do so, then the URL for the affected instance will also change to match and, as a result, your portal will no longer be configured correctly and will stop working. To fix it, you must reconfigure your portal as follows:

1. [Open the Power Platform admin center](power-platform-admin-center.md) and go to **Resources** > **Portals** on the left navigation pane.

2. Each configured portal app is listed using the name of the Dynamics 365 instance it is assigned to (so it probably doesn't have "portal" in its name), and shows a value of **Configured** in the **Status** column. Find and select your portal in the list and then select **Manage** top ribbon.  

    > [!div class="mx-imgBorder"]
    > ![Select your portal](media/faq-portal-manage4.png)

3. The portals manager opens. Select **Portal actions** in the side panel, and then select the **Update Dynamics 365 URL** tile to update the URL.  

    ![Open portal actions and then update the URL](media/faq-portal-manage3.png "Open portal actions and then update the URL")

4. You'll be asked to confirm the action. Choose **Update URL** to continue and then allow a few minutes for the process to complete.

<a name="fix-voc"></a>

## My surveys aren't working; how can I fix my Dynamics 365 Customer Voice installation?

If you don't see the **Survey** tile in the **Toolbox** of your [customer journey designer](customer-journeys-create-automated-campaigns.md), or if it isn't working properly, then the Dynamics 365 Marketing setup wizard might have failed to set up the Dynamics 365 Customer Voice app correctly. If this was the only error that occurred during installation, then you might not have received any messages about it. To fix this, do the following:

1. [Open the Power Platform admin center](power-platform-admin-center.md).

1. Go to **Resources** > **Dynamics 365 apps** on the left navigation pane, select any **Dynamics 365 Customer Voice** application in the applications list, and then select the **Install** button on the top ribbon.

    > [!div class="mx-imgBorder"]
    > ![Install Dynamics 365 Customer Voice](media/admin-cv-manage.png)

1. The **Install Dynamics 365 Customer Voice** pane opens.

    > [!div class="mx-imgBorder"]
    > ![Set up your Customer Voice installation](media/admin-cv-setup.png)

    Do the following:
    - Choose the instance you are having trouble with from the **Select an environment** drop-down list. 
    - Read the license terms and the privacy policy carefully. If you agree with their terms, select the **I agree to the terms of service** check box.

1. Select **Install**. A message at the bottom of the page announces that the installation has successfully started.

1. To track the installation progress, go back to your Power Platform admin center and open the **Environments** list. Select your environment in the list and then select **Resources** > **Dynamics 365 apps** in the top ribbon.

    > [!div class="mx-imgBorder"]
    > ![Manage the solutions installed on your environments](media/admin-cv-instances.png)

1. The **Dynamics 365 apps** page for your selected environment opens, showing a list of solutions installed on your selected environment and the status of each of them. Find the **Dynamics 365 Customer Voice** solution and then refresh the page periodically until you can see that the solution is shown as **Installed**.

    > [!div class="mx-imgBorder"]
    > ![Installation progress](media/admin-cv-solutions4.png)

1. Open Dynamics 365 Marketing, go to **Settings** > **Advanced settings** > **Marketing settings** > **Marketing data configuration**, and enable syncing of the **Survey (msdyn_survey)** entity. More information: [Choose entities to sync with the marketing-insights service](mkt-settings-sync.md)

1. Confirm that the **Survey** tile is now visible in the customer journey toolbox, and that your surveys are working correctly.

If your surveys still aren't working after completing these steps, [contact Microsoft Support](#contact-support) for assistance.

<a name="uci-only-data"></a>

## Why can't I see my Dynamics 365 Marketing results in other Dynamics 365 apps?

Dynamics 365 Marketing is built to run exclusively on the new Unified Interface for Dynamics 365 applications. Many Dynamics 365 applications support both the new Unified Interface and the older web-client interface, but nearly all are moving to the Unified Interface.

Marketing typically shares data with other Dynamics 365 applications running on the same instance, and operates on many of the same database entities, including contacts, leads, accounts, and more. Some Marketing-specific features, such as displays of analytics and insights from marketing initiatives, require the Unified Interface and therefore won't show any data when you view those entities in web-client apps.

Also, some administration and customization features, and some integrated user features, may require you to switch to a web-client app from time to time, but soon all features are expected to be available on the Unified Interface.

More information: [About Unified Interface for model-driven apps in Power Apps](https://docs.microsoft.com/power-platform/admin/about-unified-interface) and [Find your way around Marketing](navigation.md)

<a name="contact-support"></a>

## How can I contact support if I still need help?

For more support and help resources you can:

- [Contact technical support](https://docs.microsoft.com/power-platform/admin/get-help-support) directly.
- Get in touch with the community on the [Dynamics 365 Marketing forum](https://community.dynamics.com/365/marketing/f/768).
- Find more [online help resources for Dynamics 365](https://docs.microsoft.com/power-platform/admin/get-help-support).

If you’ve already tried to set up the application several times and are still having trouble, open a support case through your applicable Microsoft Premier channel or MPN partner channel.
