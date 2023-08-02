---
title: Set up Dynamics 365 Marketing
description: How to run the setup wizard for Dynamics 365 Marketing.
ms.date: 12/01/2022
ms.topic: article
author: alfergus
ms.author: alfergus
search.audienceType: 
  - admin
  - customizer
  - enduser
---

# Purchase and set up Dynamics 365 Marketing

[!INCLUDE[marketing-trial-cta](../shared/trials/marketing-trial-cta.md)]

This article explains how to purchase and set up a new Dynamics 365 Marketing environment.

<a name="how-licensed"></a>

## How to purchase Dynamics 365 Marketing

To install Dynamics 365 Marketing, you need to first purchase a base license. Which base license you choose depends on whether you already have a qualifying Dynamics 365 application. If you have Dynamics 365 Sales, Dynamics 365 Customer Service, Dynamics 365 Field Service, Dynamics 365 Supply Chain Management, Dynamics 365 Finance, or Dynamics 365 Commerce **with 10 or more users**, you can purchase the reduced price "attach" license. Otherwise, you'll need to purchase a standard Dynamics 365 Marketing license.

Once you have a core license, you can purchase additional production or non-production instances, as detailed below. You can also purchase additional contact or interaction packs. More information: [Dynamics 365 Marketing pricing](https://dynamics.microsoft.com/marketing/pricing/).

### Dynamics 365 Marketing licensing options:

#### Production app
Production versions of Dynamics 365 Marketing are licensed per tenant. Each tenant is priced according to the number of *Marketing contacts* stored in your database. To identify contacts, Marketing monitors key *interaction* types. Any contact that performs one or more interactions will be flagged as a Marketing contact and count against the allotment.

A Marketing interaction is an outbound message sent to any Marketing contact using Dynamics 365 Marketing.  The message can be sent through out-of-box channels available in Dynamics 365 Marketing (for example, email or push notifications), other Microsoft channels (for example, ACS), or third-party systems integrated with Dynamics 365 Marketing (for example, other SMS providers).

Contacts that are stored, but not marketed to using Dynamics 365 Marketing don't count towards the Marketing contacts quota. After an interaction is logged for a contact, it doesn't matter how many Marketing interactions that contact performs, the contact is still counted just once.

Each license also includes quotas that limit the total number of Litmus inbox previews you can view and marketing email messages you can send each month. With all licenses, a maximum of 100 *free* Litmus email previews can be generated per month. See your license agreement for complete details about the quota limits that apply to you. You can view your quota limits and consumption for Marketing contacts and Marketing interactions on the [Quota limits](quota-management.md) page. While you're planning your marketing activities, be sure to purchase enough Marketing contacts to remain within your quota.

> [!NOTE]
> When you sign up for Dynamics 365 Marketing, you'll choose a licensing option that defines your contract period and various quotas for that period. Each of the contacts that you engage through interactions during the contract period count against your total contact quota, even if you delete, or otherwise stop marketing to, an existing Marketing contact during the contract period.
> 
> Active marketing contacts are counted as contact entities in the Dataverse database if they have received a Marketing interaction within the last 12 months prior to the current date. Once a contact hasn't received an interaction in the last 12 months, it is no longer counted as an active contact.
> 
> You can only reduce your *purchased* contact quota on the anniversary of your contract. Marketing contact consumption is cumulative throughout the license period and even post-license extension, subject to the 12-month rule mentioned above.
>
> To learn more about Dynamics 365 Marketing pricing and licensing offers as well as prerequisites, refer to the [Dynamics 365 Licensing Guide](https://go.microsoft.com/fwlink/?LinkId=866544).

#### Non-production app
After you’ve purchased a core license, you may decide that you want to set up a test environment. A non-production license allows you to set up a non-production environment to try new features or customizations. As the name implies, you can’t use a non-production license to run production campaigns or interact with contacts.

The distinction between a non-production license and a production license is only relevant to the purchase price at the time you buy the license. Whether you use a non-production or production app, the app's interface and functionality will be the same. The non-production license simply allows you to have a separate fully functional app in a non-production environment so that you can test your configuration before implementing it in the production environment.

#### Solution Only app
A Solution Only license includes all of the entities and solutions for Dynamics 365 Marketing, but doesn't include any of the marketing services. This means that marketing capabilities aren't available in this option (including email  creation, email delivery, segmentation, customer journeys, and more). This license is intended for use on development and test environments when making customizations, solving compatibility issues, importing or exporting solutions, and doing other types of development and non-functional marketing testing. A Solution Only license is included with all paid licenses and allows you to install the Solution Only app on as many environments as needed.

As shown below, the Solution Only app appears as a separate Dynamics 365 Marketing app that is labeled **Dynamics 365 Marketing Solution Only** in the Power Platform admin center. You can set up and configure the Solution Only app using the [Marketing setup wizard](purchase-setup.md#run-the-marketing-setup-wizard).

> [!div class="mx-imgBorder"]
> ![Screenshot of the Dynamics 365 Marketing Solution Only app in the Power Platform admin center.](media/purchase-setup-solution-only.png)

As with production environments, Solution Only app updates [are pushed to all customers automatically](apply-updates.md) each time an update becomes available. To convert a Solution Only environment to a production or non-production environment, make sure you have an unconfigured production or non-production license and then [run the setup wizard](#run-wizard) to apply that license to the existing Solution Only environment. This will allow you to preserve your customizations and data from the Solution Only app.

> [!IMPORTANT]
> Solution Only apps do not support some functionality that is supported by fully paid Marketing apps, specifically, portals, insights, and their solutions. If you need to use such functionality in a non-production environment, you will need to purchase a non-production license.

## User and portal licensing

Unlike most other model-driven apps in Dynamics 365, Dynamics 365 Marketing isn't priced per user, so users already licensed to access any Dynamics 365 app on an environment where Marketing is installed will also be able to access Marketing without requiring you to purchase any additional licenses. You can even request any number of free ("zero dollar") Marketing user licenses to assign to users that don't have a Dynamics 365 license, but these free user licenses aren't valid for apps other than Marketing.

You can choose to run your marketing pages, landing pages, and events website either on an external web server (such as your own CMS system) or on a Dynamics 365 Portal or Power Apps portal running on the same tenant as your Dynamics 365 Marketing environment. Dynamics 365 Portals and Power Apps portals are licensed separately from Dynamics 365 Marketing. For details about portal licensing, see the [Power Apps and Flow licensing FAQ](/power-platform/admin/powerapps-flow-licensing-faq#can-you-share-more-details-regarding-the-new-powerapps-portals-licensing). If you use an external website for your events website and marketing pages, then no portals license is needed. You'll choose which solution to use when you run the Dynamics 365 Marketing setup wizard and can change your mind later by running it again. More information: [Integrate Marketing with a CMS system or Power Apps portals](portal-optional.md)

For more information about Dynamics 365 Marketing licensing, see the [Administration and setup FAQ](setup-troubleshooting.yml#licensing). For complete licensing details, including specific quotas and other conditions, see the  [Microsoft Dynamics 365 Licensing Guide](https://go.microsoft.com/fwlink/p/?linkid=866544).

## Prerequisites and requirements

To run the setup wizard, you must meet all the following requirements:

- You must already have a Microsoft 365 tenant.
- An unconfigured Dynamics 365 Marketing app must be available on your tenant.
- You must not already have a Dynamics 365 Marketing app installed on your Dynamics 365 environment. You can have at most one Dynamics 365 Marketing app per environment, and each Dynamics 365 Marketing app can only be used with one Dynamics 365 environment.
- You must sign into your tenant with a user account that has all the following:
   - A security role (such as _Global admin_ or [_Service support admin_](/power-platform/admin/use-service-admin-role-manage-tenant)) that allows you to modify the target Dynamics 365 environment. (If you're reinstalling Marketing on an environment where Marketing was previously installed, then _Service support admin_ users [_Dynamics 365 administrator_ or _Power Platform administrator_] must use the same user ID as was used for the initial install. If you're not sure which ID was used for the initial install, or if you're getting errors, then try to install as a _Global admin_.)
   - Permissions to register applications in Azure. The global administrator always has this right, but other accounts can also have it. See [Do I have permissions to register applications on Azure?](setup-troubleshooting.yml#register-apps-azure) for information about how to confirm this setting for your account.
   - A Dynamics 365 license with the _System Administrator_ security role assigned on your target Dynamics 365 environment. (The Dynamics 365 Marketing license agreement doesn't legally require the installing user to have this license, but a known technical issue currently makes it necessary.)
- You must be located in a country/region where the product is supported. To read the latest list of countries/regions where you can use Dynamics 365 Marketing, download the [Microsoft Dynamics 365 International Availability](https://go.microsoft.com/fwlink/p/?linkid=875097) document (PDF).
- Close all other browser windows and tabs before starting.
- Clear your browser cache before starting.

If you run into trouble while working with the setup wizard, see the [Administration and setup FAQ](setup-troubleshooting.yml) for some possible solutions.

> [!IMPORTANT]
> Your system is constrained by certain limits and quotas that apply to the number of contacts you can market to, monthly email messages you can send, Litmus previews you can view, and more. Please familiarize yourself with the terms and limits of the product before you begin to use it. The limits are different based on whether you are running a trial or subscribed version of the product.
> 
> - For subscribed (paid) versions, please download the [Microsoft Dynamics 365 Licensing Guide](https://go.microsoft.com/fwlink/p/?linkid=866544) and visit the [Fair use policy](fair-use-policy.md) page.
> - For trials, see [Dynamics 365 Marketing limits for trials](trial-preview-limits.md).
> 
> You can monitor your usage levels by going to  **Settings**  >  **Advanced settings**  >  **Other settings**  >  **Quota limits**  in Dynamics 365 Marketing. More information: [Quota limits](quota-management.md)

## Add a Marketing app to your Microsoft 365 tenant

There are many ways to add one or more Marketing apps to your Microsoft 365 tenant. For example, you can purchase it from the [Dynamics 365 Marketing overview page](https://dynamics.microsoft.com/marketing/overview/), or by going to **Billing** > **Purchase services** in your Microsoft 365 admin center, or by contacting your Microsoft sales representative or channel partner. On purchasing a license, an unconfigured Dynamics 365 Marketing app will be automatically added to your tenant.

You can have any number of Marketing apps available on your tenant. Initially, each of these apps will be unconfigured and unassigned to any Dynamics 365 environment. Later, you'll run the Marketing setup wizard to assign the app to an environment and configure it.

<a name="run-wizard"></a>

## Run the Marketing setup wizard

After purchasing your license for Dynamics 365 Marketing, you'll have an unconfigured Dynamics 365 Marketing app available on your tenant, but you still need to set it up for use. The Marketing setup wizard will help you review all the relevant privacy policies and set up and integrate its various elements.

> [!TIP]
> If you have not installed other apps on the [Microsoft Power Platform admin center](/power-platform/admin/), you will need to create an environment before you can run the Marketing setup wizard. Learn more: [Create and manage environments in the Power Platform admin center](/power-platform/admin/create-environment).

To set up a new Marketing environment:

1. Go to [admin.powerplatform.microsoft.com](https://admin.powerplatform.microsoft.com) and sign in to your Microsoft 365 tenant using an administrator account that has a Dynamics 365 Marketing license assigned.

1. Go to **Resources** > **Dynamics 365 apps** on the left navigation pane.

   ![Navigate to the Dynamics 365 apps.](media/purchase-setup-ppac-apps2.png "Navigate to the Dynamics 365 apps")

1. Find and select an unconfigured Dynamics 365 Marketing application in the **Dynamics 365 apps** list. Then select the three dots between the **Name** and the **Status** columns for the Marketing application.

    ![Choose an app and then select the Manage or Details link.](media/purchase-setup-ppac-manage.png "Choose an app and then select the Manage or Details link")

    - To launch the Dynamics 365 Marketing setup wizard, choose **Manage** from the pop-up menu. A message will pop up informing you that you're going to the Dynamics 365 Marketing admin page. To go to the page, select **OK**.
    
      ![Dynamics 365 Marketing admin page prompt.](media/purchase-setup-ppac-prompt.png "Dynamics 365 Marketing admin page prompt")
    
    - To view more details about the selected Marketing application, choose **Details** from the pop-up menu.

    You may have more than one type of application available, so be sure to pick the one that meets your present needs. Both types of applications present the same setup wizard, as described in this procedure. They're identified as follows:

    - **Dynamics 365 Marketing Application**: This is a full Dynamics 365 Marketing application, including both solutions and services. It's intended for production use, but can also be used during development and testing.
    - **Dynamics 365 Marketing - Solution Only**: This application provides the Dynamics 365 Marketing solutions, including all database entities, but not the services. This means that marketing capabilities aren't available. It provides limited functionality but can be installed on as many test or development environments as needed for no additional charge. More information: [How Marketing is licensed](#how-licensed).

   > [!NOTE]
   > If you see the Marketing app listed several times, you probably have several Marketing apps available on your tenant. Marketing apps that are already configured show an environment ID appended to the app name and show a value of **Configured** in the **Status** column. Marketing apps that aren't assigned show a value of **Not configured** in the **Status** column and don't include an environment ID in their name.

1. The setup wizard launches, which you'll use to make initial settings for the app. The first page of the wizard lets you choose where you'll install the app and to choose whether to set up a portal to run your marketing pages and event website.

    > [!div class="mx-imgBorder"]
    > ![Choose an organization and name your portal.](media/setup-form-3-2.png)

1. From the top drop-down list, select the Dynamics 365 organization where you want to add Dynamics 365 Marketing. (A Dynamics 365 *organization* is another name for a Dynamics 365 *environment*.)

1. Select one of the following **Web hosting** options (you can easily [change this later](portal-optional.md), at any time):

    - **Use your own webserver**: Select this option if you'll run your landing pages and event website on an external webserver or CMS system. This option doesn't require a portals license and won't install a portals trial. If you're not sure whether you'll need a portal, then you can choose this option for now and then come back and change it later if needed.
    - **Use Dynamics 365 Portals or a Power Apps portal**: Select this option if you'll run your landing pages and event website on a dedicated Dynamics 365 or Power Apps Portal running on your tenant and linked to  your Dynamics 365 Marketing environment. Portals are licensed separately. If you already have an unconfigured Dynamics 365 Portals or a Power Apps portal license on your tenant, then Dynamics 365 Marketing will claim that license and integrate with it. If you don't have any Dynamics 365 Portals or Power Apps portals licenses available, then the setup wizard will create a trial Power Apps Portals environment and integrate with that. The trial is free, but expires in 30 days, after which you must either begin paying for it or stop using it. (Power Apps Portals licenses are priced according to consumption (logins and page loads), while Dynamics 365 Portals licenses are priced per environment.) For details about portal licensing, see the [Power Apps and Flow licensing FAQ](/power-platform/admin/powerapps-flow-licensing-faq#can-you-share-more-details-regarding-the-new-powerapps-portals-licensing).

    More information: [Integrate Marketing with a CMS system or Power Apps portals](portal-optional.md)

    > [!NOTE]
    > Power Apps portals aren't available in all countries/regions. If this applies to you, then the **Use Dynamics 365 Portals or a Power Apps portal** option won't be available and you'll see a notice here instead. For more information about how to run Marketing without a portal, and how to switch to a portal if they later become available in your country/region, see [Integrate Marketing with a CMS system or Power Apps portal](portal-optional.md).

1. If you selected to **Use Dynamics 365 Portals or a Power Apps portal**, then enter a prefix for your portal URL in the field provided (under **Where do you want to host your webpage?**). You can also see what the full URL will be here. All your portals are hosted on your tenant, which uses a Microsoft-owned domain name, plus the subdomain name that you choose here. Your contacts and customers can see the URL when they open a portal, so you should choose a subdomain name that they'll recognize, such as your organization's name. The subdomain that you choose must also be unique among all other subdomains in the same tenant; you'll be notified to try again if you pick one that's already in use. If you want to reuse a name that's reported as already in use, then you can reclaim it by resetting the relevant portal and then removing the binding to the existing name as described in [Reset any Power Apps portals connected to the uninstalled Marketing app](uninstall-marketing.md#reset-portal).

1. Select  **Setup**  to start setting up the app. A page will open that tracks the setup progress, which typically takes about three hours to set up a paid environment.

## Privacy notice

[!INCLUDE[cc-privacy-marketing-fre](../includes/cc-privacy-marketing-fre.md)]

### See also

[How Dynamics 365 Marketing uses cookies](cookies.md)  
[Engage with customers online with portals](portals.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
