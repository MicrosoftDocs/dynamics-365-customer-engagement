---
title: "Create or edit an opportunity (Dynamics 365 for Sales) | MicrosoftDocs"
description: "An opportunity is a deal you're ready to win. Create an opportunity record for a lead who's ready to buy."
keywords: "opportunity, deal, develop, propose, nurture sales"
ms.date: 04/01/2018
ms.service: crm-online
ms.custom: 
ms.topic: get-started-article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 692b7303-d9e1-4323-9e81-ab0dee4cfd2d
author: shubhadaj
ms.author: shujoshi
manager: sakudes
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
caps.latest.revision: 58
topic-status: Drafting
---

# Create or edit an opportunity (Sales and Sales Hub)

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

An opportunity is a lead who is now almost ready to buy&mdash;in other words, a deal that you're ready to win.  
  
 At this point in the sales process, you're most likely in either the **Develop** or **Propose** stage. [!include[proc-more-information](../includes/proc-more-information.md)] [Nurture sales from lead to order](../sales-enterprise/nurture-sales-from-lead-order-sales.md) 
  
<a name="bkmk1"></a>   
## Create an opportunity (Sales Hub)

[//]: # (Adding italic in the introduction is suggested because you're defining--or at least, linking to a definition--of these terms. Using lowercase "or" between the alternative steps is something I've recently discovered in the Writing Style Guide. The "site map" wording is edited to be consistent with the content I've seen and I've edited myself, but I will explicitly verify this with Renee.)
If you're following the sales process from start to finish, you *qualify* a lead to turn it into an *opportunity*. [!include[proc-more-information](../includes/proc-more-information.md)] [Qualify a lead and convert it to an opportunity](../sales-enterprise/qualify-lead-convert-opportunity-sales.md)
1. Select the site map ![Site Map icon](media/site-map-icon.png "site map icon"), and then select **Opportunities**.

2. If you've qualified a lead to an opportunity, open the opportunity from the list.

    or

    To create a new opportunity, on the command bar, select **+ New**.

3. In the opportunity form, make sure that your potential customer's important details are captured. If you've qualified a lead to an opportunity, most of the fields will be automatically populated from the lead record.
 
   - **Topic**: What the customer is interested in that created the opportunity, such as specific product details.
 
   - **Contact**: The contact associated with this opportunity.
 
   - **Account**: The account associated with this opportunity.
 
   - **Purchase Timeframe**: The timeframe by when the account or contact is likely to make the purchase.
 
   - **Budget Amount** 
 
   - **Purchase Process**: Whether the purchase process involves an individual or a committee.
 
   - **Est. Close Date**: An estimated date by which the opportunity is expected to close. 
 
   - **Est. Revenue**: A field calculated for opportunities that have products added to them. Estimated revenue is calculated based on base price, volume discounts, manual discounts, taxes, and other pricing modifications. When opportunities are saved, [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)] recalculates the estimated revenue based on any changes to the products or product quantities associated with the opportunity.

4.	Select **Save** to enable other sections on the form.

5.	In the **Stakeholders** section, select the **More Commands** button ![More Commands button](media/more-button-stakeholders-grid.png "More Commands button"), and then select **+ New Connection** to add a contact as a stakeholder. A *stakeholder* is a key contact at the account who will be involved in decision-making. 

    In the **Lookup Records** dialog box, enter a name or select the Lookup icon to choose from a list of suggestions. When you have entered the name you want, select **Add**. To create a new contact, select **+ New**. By default, the contact you add is assigned the Stakeholder role. Select the Role corresponding to the contact to select a different role such as Decision Maker or Technical Buyer. 

6.	In the **Sales Team** section, select the **More Commands** button ![More Commands button](media/more-button-stakeholders-grid.png "More Commands button"), and then select **+ New Connection** to add a member of the sales team (from your organization).

7.	In the **Competitors** section, select **Add Existing Competitor** to add a competitor who's competing with your organization for this opportunity.

8.	To save your changes, on the command bar, select **Save**.

9.	Add products to your opportunity. [!include[proc-more-information](../includes/proc-more-information.md)] [Add products to an opportunity](#add-products-to-an-opportunity-sales-hub) 

10.	Follow the process bar to move the opportunity to the next stage. In the **Develop** stage, enter data for the following fields:
    
    - **Customer Need**: Enter what interests the customer, such as specific product requirements.
    
    - **Proposed Solution**: Enter the plan for what your organization can offer the account, such as product details.
    
    - **Identify Stakeholders**: Select **mark complete** to indicate that you've included information about who will be involved in pursuing the opportunity.
    
    - **Identify Competitors**: Select **mark complete** to indicate that you've included information about competitors.

11. In the **Propose** stage, select **mark complete** to display a check mark next to each of the following steps that you've completed:
    
    - **Identify Sales Team**  
    
    - **Develop Proposal** (this optional step indicates that you've included notes about how the account will be approached)  
    
    - **Complete Internal Review**  
    
    - **Present Proposal**  

The next step is to create a quote and send it to your customer. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Create a quote and send it to your customer](../sales-enterprise/create-edit-quote-sales.md)

<a name="bkmk2"></a>   
## Add products to an opportunity (Sales Hub)

[//]: # (In step 6, substep 1, I'm not sure how to describe interacting with this control. The Writing Style Guide says to use "switch" in place of "toggle", but "switch the field" didn't seem right. I'll check this with Renee.)
1. In the list of opportunities, open the opportunity to which you want to add products.

2. Go to the **Product Line Items** tab.

3. Select a **Price List**.

4. If you want the pricing of the products to be automatically calculated based on the products and quantities you add, set **Revenue** to **System Calculated**. If you want to override the default pricing, set it to **User Provided**.

5. In the **Product Line Items** grid, select **Add New Opportunity Product**.

6. In the **New Opportunity Product** form, do the following:  

    1.  **Select Product**: Set the switch to choose whether you want to add an existing product or create a new one:<ul><li>To use an existing product, select **Lookup** to search for and add a product.</li><li> To create a product, select **Write-In**, and then enter the name of the product.</li></ul>  
    
    2.  **Pricing**. Select the pricing option. By default, this is the price that is listed in the product catalog. To override the catalog price, select **Override Price**. When you override the price, you can specify a price that you want to charge for each unit of the product.  

    3.  **Quantity**. Enter the quantity of the product or service that will be included.  

    4.  **Manual Discount**. If you want to offer a discount to the product price, enter it here.  
    
    5.  **Tax**. If required, enter the appropriate tax amount.  

    6.  On the command bar, select **Save**.  

7. Select **Save**.

<a name="bkmk3"></a>   
## Recalculate an opportunity (Sales Hub)

To change the estimated revenue of an opportunity based on any changes you've made to the associated products or product quantities, recalculate the opportunity.

1.	In the list of opportunities, open the opportunity for which you want to recalculate the estimated revenue.

2.	Go to the **Product Line Items** tab, and verify that **Revenue** is set to **System Calculated**.

3.	In the grid, modify the list of products associated with the opportunity.

4.	Select **Save**.

5.	On the command bar, select **Recalculate Opportunity**.


<a name="bkmk4"></a>   
## Create an opportunity  (Sales app)
 If you're following the sales process from start to finish, you qualify a lead to turn it into an opportunity. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Nurture sales from lead to order](../sales-enterprise/nurture-sales-from-lead-order-sales.md)  

 If you want to create an opportunity without first creating a lead, do the following:  
  
1. [!INCLUDE[proc_sales_opportunities](../includes/proc-sales-opportunities.md)]  
  
2.  Select **New**.  
  
3.  In the **Summary** area, enter the company and contact information for the opportunity.  
  
4.  In the **Details** area of the **Opportunity** form, enter information about your opportunity's industry and preferred contact method.  
  
5.  Add any notes and activities (for example, phone calls or emails) related to this opportunity. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Keep track of notes, tasks, calls, or email with activities](../basics/work-with-activities.md)  
  
6.  In the **Stakeholders** section, select the **Add Connection record** button ![Add Connection record button](media/add-connection-record-button.png "Add Connection record button") to add a contact as a stakeholder. A *stakeholder* is a key contact at the account who will be involved in decision-making. 

    In the Lookup box, enter a name or select the Lookup icon to choose from a list of suggestions. To create a new contact, select **+ New**. By default, the contact you add is assigned the Stakeholder role. Select the Role corresponding to the contact to select a different role such as Decision Maker or Technical Buyer.   
  
7.  In the **Sales Team** section, select the**Add Connection record** button ![Add Connection record button](media/add-connection-record-button.png "Add Connection record button"), and then select **+ New Connection** to add a member of the sales team (from your organization).  
  
8.  To add competitors, in the **Competitors** area, select **+**.  
  
9.  To add products, in the **Products** area, select **+**.  
  
10. To add a quote, in the **Quotes** area, select **+**. [!include[proc-more-information](../includes/proc-more-information.md)] [Create or edit a quote](../sales-enterprise/create-edit-quote-sales.md)  
  
11. Select **Save** in the lower-right corner of the screen. 
  
  
<a name="bkmk5"></a>   
## Additional considerations  
  
-   A way that might help you increase your sales is to add all products that your customer might need. You can add product bundles or product families to make it easier for you to choose products for upsell and cross-sell.  
  
-   If other people in your organization are working on this sale, be sure to add them as sales team members.  
  
-   Nurture your opportunities through a marketing campaign. [!include[proc-more-information](../includes/proc-more-information.md)] [Get started with in-app marketing](../sales-enterprise/get-started-with-app-marketing-sales.md) (applies to the Sales app only)
  
<a name="bkmk6"></a>   
## Tips and tricks  
 Need a faster way to enter opportunities? Try one of these:  
  
-   [Quick create: enter new contacts (or other data)&mdash;fast!](../basics/quick-create-enter-data-fast.md)  
  
-   [Import accounts, leads, or other data](../basics/import-accounts-leads-other-data.md)  
  
<a name="bkmk7"></a>   
## Typical next steps  
 ![Right arrow button](../sales-enterprise/media/orange-right-arrow-button.png "Right arrow button") [Create or edit a quote](../sales-enterprise/create-edit-quote-sales.md)  
  
 ![Home button](../sales-enterprise/media/home-button.png "Home button") [Learn about the sales process, nurturing sales from lead to order](../sales-enterprise/nurture-sales-from-lead-order-sales.md)  
  
### See also  
 [Run a report](../basics/run-report.md)   
 [Assign a record to a user or team](../basics/assign-record-user-team.md)      
 [Stay up-to-date with customer news with the activity feed](../basics/stay-up-date-with-customer-news-with-activity-feed.md)   
 [Print leads, quotes, and other records](../basics/print-leads-quotes-other-records.md)   
 [Boost sales with Versium Predict](../versium-predict/versium-predict.md)   
 [Insights, powered by InsideView](../insights-insideview/insights-powered-by-insideview.md)   
