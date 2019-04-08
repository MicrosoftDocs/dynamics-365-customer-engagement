---
title: "Switch from Dynamics CRM Online to Dynamics 365 for Customer Engagement apps (online) | MicrosoftDocs"
ms.custom: 
ms.date: 07/12/2018
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement  (online)
  - Dynamics 365 for Customer Engagement  Version 9.x
ms.assetid: 258663fb-fefa-4427-b25d-c935c3896aed
caps.latest.revision: 13
author: jimholtz
ms.author: jimholtz
manager: kvivek
search.audienceType: 
  - admin
search.app: 
  - D365CE
  - Powerplatform
---
# Switch from Dynamics CRM Online to Dynamics 365 for Customer Engagement apps (online)

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

Your Dynamics CRM Online plan is being retired. When it's time to renew, you'll need to renew using the new Dynamics 365 for Customer Engagement apps plans. To learn more about your options, see [Important information for CRM Online customers](../admin/important-information-customers.md).  

 If you're an existing Dynamics CRM Online customer, you will be notified when your subscription will expire.  At that time, you'll need to start a new subscription with one of the new Customer Engagement apps licenses. You can switch before you receive the expiration notice.  

 ![Email: Dynamics 365 for Customer Engagement apps (online) is expiring](../admin/media/expireemail.png "Email: Dynamics 365 for Customer Engagement apps (online) is expiring")  

 **Dynamics 365 for Customer Engagement apps information**  

-   [Dynamics 365 for Customer Engagement](https://www.microsoft.com/dynamics365/home)  

-   [Dynamics 365 for Customer Engagement apps pricing](https://www.microsoft.com/dynamics365/pricing)

-   [Dynamics 365 for Customer Engagement apps Licensing Guide](https://go.microsoft.com/fwlink/p/?LinkId=866544)  

-   [Existing Customer License Transition Guide](http://download.microsoft.com/download/7/A/4/7A421751-435B-4B38-BF1F-45838095465B/Microsoft%20Dynamics%20365%20Transition%20Guide.pdf)  

-   [Business apps in Dynamics 365 for Customer Engagement](../basics/business-apps-dynamics-365.md)  

<a name="BKMK_SwitchToSalesCSTeam"></a>   

## How to renew when your plan is retiring  
 The easiest way to switch plans is to use the Switch plans button in the Microsoft 365 admin center which launches a wizard. However, using the Switch plans button isn’t supported in all situations. In some cases, you might want or need to switch plans manually.  

 **When to use the Switch plans wizard**  

 Click the Switch plans button if:  

- You want to simplify the renewal process.  

- You're going to assign all your users to the same [!INCLUDE[pn_dyn_365](../includes/pn-crm-shortest.md)] plan.  

See [Use the Switch plans wizard](#BKMK_SwitchPlan).  

**When to switch plans manually**  

 Manually switch plans if:  

- You want more control of the renewal process.  

- You have a mix of [!INCLUDE[pn_dyn_365](../includes/pn-crm-shortest.md)] plans to assign users to.  

- You're going to purchase fewer licenses in the [!INCLUDE[pn_dyn_365](../includes/pn-crm-shortest.md)] plan than you currently have in your CRM Online plan.

See [Switch plans manually](#BKMK_ManualSwitch).  

<a name="BKMK_SwitchPlan"></a>   

### Use the Switch plans wizard  
 When you click the Switch plans button, you're led through the process of buying a new plan that you can switch your current plan to.  

 The switch plans wizard does the following:  

-   Leads you through the process of buying a new plan.  

-   Reassigns all user licenses from your old plan to the new plan.  

-   Cancels your old plan.  

To renew to [!INCLUDE[pn_dyn_365](../includes/pn-crm-shortest.md)] using the Switch plans wizard, follow these steps.  

1. [!INCLUDE[proc_office365_signin](../includes/proc-office365-signin.md)]  

2. Choose **Billing** > **Subscriptions**.  

   ![Choose Billing &#62; Subscription](../admin/media/choose-billing-subscription.png "Choose Billing > Subscription")  

3. If you have a Partner of Record, take note of the Partner ID to use later. Under **Active**, click **More actions** > **Edit partner of record** and record the ID number.  

   ![Find your Partner of Record](../admin/media/find-your-partner-of-record.png "Find your Partner of Record")  

4. Select the plan to renew, and then click **Switch plans**.  

   ![Subscription Switch plans button](../admin/media/subscription-switch-plans-button.png "Subscription Switch plans button")  

5. Mouse over the subscription you want to switch to, and then click **Buy now**.  

   ![Subscription Buy now button](../admin/media/subscription-buy-now-button.png "Subscription Buy now button")  

   > [!NOTE]
   >  If you need to purchase a mix of plans, each plan must be purchased separately in order to apply promo codes for discounted pricing and to assign licenses.  

    Choose a plan to switch to.  


   |                                                                                                                                                                 |                                                                                                  |
   |-----------------------------------------------------------------------------------------------------------------------------------------------------------------|--------------------------------------------------------------------------------------------------|
   | ![Dynamics 365 for Customer Engagement apps Plan 1 Enterprise Edition](../admin/media/dynamics-365-plan-1-enterprise-edition.png "Dynamics 365 for Customer Engagement apps Plan Enterprise Edition") | ![Dynamics 365 for Customer Engagement Sales Plan](../admin/media/dynamics-365-sales-plan.png "Dynamics 365 for Customer Engagement Sales Plan") |
   |                ![Dynamics 365 for Customer Engagement apps Customer Service Plan](../admin/media/dynamics-365-customer-service-plan.png "Dynamics 365 for Customer Engagement apps Customer Service Plan")                |  ![Dynamics 365 for Customer Engagement apps Team Plan](../admin/media/dynamics-365-team-plan.png "Dynamics 365 for Customer Engagement apps Team Plan")   |


6. In the Checkout Step 1 page, click **Have a promo or discount code?**, enter a promo code, and then click **Apply promo code**.  

   ![Apply a promotion code](../admin/media/apply-promotion-code.png "Apply a promotion code")  

    For current CRM Online customers, we are offering discounted pricing on [!INCLUDE[pn_dyn_365](../includes/pn-crm-shortest.md)] plans when you transition. Click on your subscription type to find your promo code, then return and complete the remaining steps.  

   |Subscription type|  
   |-----------------------|  
   |[Promo codes: Commercial Web Direct](../admin/promo-codes-commercial-web-direct.md)|  
   |[Promo codes: Government Web Direct](../admin/promo-codes-government-web-direct.md)|  
   |[Promo codes: Faculty Web Direct](../admin/promo-codes-faculty-web-direct.md)|  
   |[Promo codes: Student Web Direct](../admin/promo-codes-student-web-direct.md)|  
   |[Promo codes: Non-profit Web Direct](../admin/promo-codes-non-profit-web-direct.md)|  

   > [!IMPORTANT]
   >  If you're considering a mix of plans, you must complete that transition in a separate transaction with each promo code.  

7. Click **Next**. On the Checkout Step 2 page, if you have a partner, click **Add** in the right-side of the page, and then use the Partner ID you recorded above.  

   ![Click Add to add a partner](../admin/media/click-add-partner.png "Click Add to add a partner")  

8. Fill in the information, and then click **Place  order**.  

<a name="BKMK_ManualSwitch"></a>   

### Switch plans manually  
 Switching plans manually means completing the following separate procedures instead of using the switch plans wizard.  

-   Buy licenses for the new subscription.  

-   Verify the new subscription is ready to use.  

-   Reassign user licenses.  

-   Remove unneeded licenses from the subscription you’re switching from.  

-   Cancel the original subscription.  

To manually switch users to another [!INCLUDE[pn_dyn_365](../includes/pn-crm-shortest.md)] subscription, complete the following phases in the order shown.  

- Phase 1: Buy user licenses for a [!INCLUDE[pn_dyn_365](../includes/pn-crm-shortest.md)] subscription.  

- Phase 2: Verify that your subscription has the right number of licenses.  

- Phase 3: Reassign user licenses.  

- Phase 4: Cancel the CRM Online subscription.  

<a name="BKMK_BuyLicense"></a>   
### Phase 1: Buy user licenses for your [!INCLUDE[pn_dyn_365](../includes/pn-crm-shortest.md)] subscriptions  

1. [!INCLUDE[proc_office365_signin](../includes/proc-office365-signin.md)]  

2. Choose **Billing** > **Subscriptions**.  

   ![Choose Billing &#62; Subscription](../admin/media/choose-billing-subscription.png "Choose Billing > Subscription")  

3. If you have a Partner of Record, take note of the Partner ID to use later. Under **Active**, click **More actions** > **Edit partner of record** and record the ID number.  

   ![Find your Partner of Record](../admin/media/find-your-partner-of-record.png "Find your Partner of Record")  

4. Above **Active**, click **+ Add subscriptions** and select the offer for the service  you want and proceed through the purchase process.  

   > [!NOTE]
   >  If you need to purchase a mix of plans, each plan must be purchased separately in order to apply promo codes for discounted pricing and to assign licenses.  

    Choose a plan to switch to.  


   |                                                                                                                                                                 |                                                                                                  |
   |-----------------------------------------------------------------------------------------------------------------------------------------------------------------|--------------------------------------------------------------------------------------------------|
   | ![Dynamics 365 for Customer Engagement apps Plan 1 Enterprise Edition](../admin/media/dynamics-365-plan-1-enterprise-edition.png "Dynamics 365 for Customer Engagement apps Plan Enterprise Edition") | ![Dynamics 365 for Customer Engagement Sales Plan](../admin/media/dynamics-365-sales-plan.png "Dynamics 365 for Customer Engagement Sales Plan") |
   |                ![Dynamics 365 for Customer Engagement apps Customer Service Plan](../admin/media/dynamics-365-customer-service-plan.png "Dynamics 365 for Customer Engagement apps Customer Service Plan")                |  ![Dynamics 365 for Customer Engagement apps Team Plan](../admin/media/dynamics-365-team-plan.png "Dynamics 365 for Customer Engagement apps Team Plan")   |


5. Mouse over the subscription you want to switch to, and then click **Buy now**.  

   ![Subscription Buy now button](../admin/media/subscription-buy-now-button.png "Subscription Buy now button")  

   > [!NOTE]
   >  If you need to purchase a mix of plans, each plan must be purchased separately in order to apply promo codes for discounted pricing and to assign licenses.  

6. Adjust the plan options, and then click **Add to cart**.  

   ![Dynamics 365 for Customer Engagement apps Enterprise Plan settings](../admin/media/dynamics-365-enterprise-plan-settings.png "Dynamics 365 for Customer Engagement apps Enterprise Plan settings")  

7. In your cart, click **Add-ons** to add Add-ons like an additional non-Production instance or more storage.  

   ![Click Add-on in your cart](../admin/media/click-add-on-your-cart.png "Click Add-on in your cart")  

    To see which add-ons are included with [!INCLUDE[pn_dyn_365](../includes/pn-crm-shortest.md)] plans, see [Important information for CRM Online customers](../admin/important-information-customers.md).  

8. Click **Check out** in your cart.  

9. In the Checkout Step 1 page, click **Have a promo or discount code?**, enter a promo code, and then click **Apply promo code**.  

   ![Apply a promotion code](../admin/media/apply-promotion-code.png "Apply a promotion code")  

     For current CRM Online customers, we are offering discounted pricing on [!INCLUDE[pn_dyn_365](../includes/pn-crm-shortest.md)] plans when you transition. Click on your subscription type to find your promo code, then return and complete the remaining steps.  

    |Subscription type|  
    |-----------------------|  
    |[Promo codes: Commercial Web Direct](../admin/promo-codes-commercial-web-direct.md)|  
    |[Promo codes: Government Web Direct](../admin/promo-codes-government-web-direct.md)|  
    |[Promo codes: Faculty Web Direct](../admin/promo-codes-faculty-web-direct.md)|  
    |[Promo codes: Student Web Direct](../admin/promo-codes-student-web-direct.md)|  
    |[Promo codes: Non-profit Web Direct](../admin/promo-codes-non-profit-web-direct.md)|  

    > [!IMPORTANT]
    >  If you're considering a mix of plans, you must complete that transition in a separate transaction with each promo code.  

10. Click **Next**. On the Checkout Step 2 page, if you have a partner, click **Add** in the right-side of the page, and then use the Partner ID you recorded above.  

    ![Click Add to add a partner](../admin/media/click-add-partner.png "Click Add to add a partner")  

11. Fill in the information, and then click **Place  order**.  

<a name="BKMK_VerifyLicense"></a>   
### Phase 2: Verify that your subscription has the right number of licenses  
 It’s important to make sure that all the services inside your new subscription have been set up before moving on to the next phase. If the subscription isn’t ready when you first check, try again later.  

> [!NOTE]
>  If you purchased a subscription by invoice and a credit check is required, it can take up to two business days before the subscription is available.  

1. In the admin center, choose **Billing** > **Subscriptions**.  

2. Make sure that the [!INCLUDE[pn_dyn_365](../includes/pn-crm-shortest.md)] subscriptions appear under **Active**, and that the number of purchased licenses is correct.  

<a name="BKMK_ReassignLicense"></a>   
### Phase 3: Reassign user licenses  
 You can use the [!INCLUDE[pn_office_365_admin_center](../includes/pn-office-365-admin-center.md)] to reassign licenses for up to 20 users at a time.  

> [!TIP]
>  If you have a lot of users, you can optionally use Remote PowerShell to assign user licenses. To learn how, see [Use Office 365 PowerShell to assign licenses to user accounts](https://technet.microsoft.com/library/dn771770.aspx).  

1. In the admin center, choose **Users** > **Active users**.  

2. Select the boxes next to the names of the users that you want to move to the [!INCLUDE[pn_dyn_365](../includes/pn-crm-shortest.md)] subscriptions.  

3. In the **Bulk actions**-pane, choose **Edit product licenses**.  

4. Select **Replace existing product license assignments** > **Next**.  

5. Toggle the switches to **Off** to remove a license and **On** to add a license to users.  

6. When you’re done, choose **Replace** > **Close**.  

<a name="BKMK_CancelSubscription"></a>   
### Phase 4: Cancel the CRM Online subscription  
 Once you've moved all your Dynamics CRM Online users to [!INCLUDE[pn_dyn_365](../includes/pn-crm-shortest.md)] plans, you're ready to cancel your Dynamics CRM Online subscription.  

> [!TIP]
>  Be sure to assign [!INCLUDE[pn_dyn_365](../includes/pn-crm-shortest.md)] licenses to all your users before cancelling your Dynamics CRM Online subscription so current users don't lose access.  

1. [!INCLUDE[proc_office365_signin](../includes/proc-office365-signin.md)]  

2. Choose **Billing** > **Subscriptions** and select your **Dynamics CRM Online** subscription.  

3. On the right-hand side of the page, click **More actions** > **Cancel subscription**.  

   ![Cancel your Dynamics 365 for Customer Engagement apps (online) subscription](../admin/media/cancel-your-online-subscription.png "Cancel your Dynamics 365 for Customer Engagement apps (online) subscription")  

4. Fill in the information on the Cancel subscription page, and the click **Cancel subscription**.  

When you check your Dynamics CRM Online subscription (**Billing** > **Subscriptions**),  you'll see the following regarding your cancelled subscription:  

- You're no longer being billed for the subscription.  

- You'll receive a prorated credit for any unused service 30 to 60 days from the date you switched plans.  

- The subscription is disabled with reduced functionality.  

  ![Subscription cancellation information](../admin/media/subscription-cancellation-information.png "Subscription cancellation information")  

<a name="BKMK_DataSwitch"></a>   
## What happens to my data when I switch to a Dynamics 365 for Customer Engagement apps subscription?  
 Your data, user records, customization, etc. are stored in your tenant and are not tied directly to a specific CRM Online subscription. When you switch to a [!INCLUDE[pn_dyn_365](../includes/pn-crm-shortest.md)] subscription, the new licenses provide access to your existing CRM organization and will not lead to any loss of data.  

<a name="BKMK_NoSwitch"></a>   
## What happens if I do not switch to a Dynamics 365 for Customer Engagement apps subscription?  
 If you do not switch to a [!INCLUDE[pn_dyn_365](../includes/pn-crm-shortest.md)] subscription before the term end date, the CRM Online subscription will enter into an expired state for 90 days for most subscriptions, in most countries and regions. At the end of the expired state, the subscription moves into the disabled state, which is 90 days for most subscriptions, in most countries and regions. We recommend that you back up your data before the subscription is disabled, but as an admin, you can still access and back up data for your organization while it is in the disabled state. Any customer data that you leave behind may be deleted after 90 days, and will be deleted no later than 180 days after cancellation.  

 Here's what to expect for you and your users if your subscription is disabled.  

- **Admin access**:   Admins can still sign in and access the [!INCLUDE[pn_office_365_admin_center](../includes/pn-office-365-admin-center.md)], and buy other [!INCLUDE[pn_Office_365](../includes/pn-office-365.md)] subscriptions as needed. As a global or billing admin, you have 90 days to reactivate the subscription with all data intact.  

- **User access**:       Your users won't be able to use [!INCLUDE[pn_Office_365](../includes/pn-office-365.md)] services like [!INCLUDE[pn_onedrive_for_business](../includes/pn-onedrive-for-business.md)], or access customer data—for example, email or documents on team sites. [!INCLUDE[pn_office_shortest](../includes/pn-office-shortest.md)] applications, like [!INCLUDE[pn_ms_Word_short](../includes/pn-ms-word-short.md)] and [!INCLUDE[pn_Excel_short](../includes/pn-excel-short.md)], will eventually move into a read-only, reduced functionality mode and display Unlicensed Product notifications.  

<a name="BKMK_ContactHelp"></a>   
## Need help? Contact support.  
 As an admin for Dynamics 365 for Customer Engagement, you get free access to our knowledgeable support agents for pre-sales, account, and billing support, as well as for help resolving technical issues. You can also contact support on behalf of Dynamics 365 for Customer Engagement apps users in your organization. See [Billing and subscription support](billing-support.md).  

### See also  
 [Important information for CRM Online customers](../admin/important-information-customers.md)   
 [Switch to a different Office 365 for business plan](https://support.office.com/article/Switch-to-a-different-Office-365-for-business-plan-73318661-8f33-478b-bcc7-fb8d69dbb22a?ui=en-US&rs=en-US&ad=US)   
 [Onboard your organization and users to Dynamics 365 for Customer Engagement apps (online)](onboard-your-organization-and-users-to-dynamics-365-online.md)<br />
 [Purchase and assign Dynamics 365 for Customer Engagement apps (online) licenses](../admin/purchase-assign-online-licenses.md)   
 [Assign or remove licenses for Office 365 for business](https://support.office.com/article/Assign-or-remove-licenses-for-Office-365-for-business-997596b5-4173-4627-b915-36abac6786dc)
 [Terminology used in the product and documentation](online-terminology.md)
