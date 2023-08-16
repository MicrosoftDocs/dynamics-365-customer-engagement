---
title: Purchase Dynamics 365 Marketing
description: How to purchase Dynamics 365 Marketing.
ms.date: 08/15/2023
ms.topic: article
author: alfergus
ms.author: alfergus
search.audienceType: 
  - admin
  - customizer
  - enduser
---

# Purchase Dynamics 365 Marketing

[!INCLUDE[consolidated-sku-rtm-only](../includes/consolidated-sku-rtm-only.md)]

[!INCLUDE[marketing-trial-cta](../shared/trials/marketing-trial-cta.md)]

This article explains how to purchase a new Dynamics 365 Marketing environment.

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

[!INCLUDE[footer-include](../includes/footer-banner.md)]
