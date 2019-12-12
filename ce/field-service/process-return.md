---
title: "Process a return (Dynamics 365 Field Service) | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 12/11/2019
ms.reviewer: 
ms.service: dynamics-365-customerservice
ms.suite: 
ms.technology: 
  - field-service
ms.tgt_pltfrm: 
ms.topic: article
author: krbjoran
ms.assetid: dc861210-2993-4722-baf8-492d159701a0
caps.latest.revision: 17
ms.author: krbjoran
manager: shellyha
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365FS
---
# Process a return (RMAs and RTVs)

In [!INCLUDE[pn_dyn_365_field_service](../includes/pn-dyn-365-field-service.md)], a return merchandise authorization (RMA) is created in the system when a product is returned. There are three ways of returning a product: return to warehouse, return to vendor (RTV), or change equipment ownership.  
  
 All product returns are initiated with an RMA. The RMA designates the product, unit, quantity, related work order, and price list for the return. It also specifies the processing action, which is the type of return.  
  
 A return is not finalized until an RMA receipt is created. The RMA receipt confirms that the correct product and quantity are received, as well as the date and person handling the receipt.  
  
 After the RMA receipt is processed, the correct inventory or equipment adjustment is carried out. This can be a return to the warehouse, RTV, or a change in  equipment ownership.  
  
 In cases where a product must be returned to a vendor, an RTV must be created after receipt of the product that is going back to the vendor. 
  
<a name="BKMK_1"></a>   
## Step 1: Create an RMA  
  
1. From the main menu, click **Field Service** > **RMAs**.  
  
2. On the **Active RMAs** screen, click **+New**  
  
3. [!INCLUDE[proc_handy_infotips](../includes/proc-handy-infotips.md)]  
  
   - If the product was used in a work order, choose the related **Work Order** where the product was used. The related **Service Account** is automatically filled in when you choose a work order.  
  
   - Choose an RMA substatus, for example, Exchange, Repair, Retire, or Upgrade. These options are configurable in the admin section. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create an RMA sub-status](../field-service/create-rma-sub-status.md)  
  
   - Select the **Date Requested** and if it's **Taxable** or not.  
  
   - Specify the price of the product being returned by choosing a **Price List**.  
  
4. When you're done, click **Save**.  
  
<a name="BKMK_2"></a>   
## Step 2: Add RMA products  
 Once an RMA is created, you must add the products to be returned. There are two ways to add RMA products—either manually or by choosing a product that was used in a work order.  
  
**To add products manually, do this:**  
  
1.  In the RMA record, scroll down to the **Product** section, and then click **+Add RMA Product Record.**  
  
2.  Use the tooltips to help fill in your information, and then click **Save & Close**.  
  
**Or, to add products used in a work order, do this:**  
To **Add WO Products**, a work order must be associated with the RMA.  
  
1.  In the RMA record, on the command bar at the top, click **Add WO Products**. The **Add WO Products** dialog box opens.  
  
2.  From the list of **Work Order Products**, select the **Return** check box for the products that are being returned.  
  
    > [!NOTE]
    >  If the full quantity is not to be returned, you can choose a different value in the **Return Value** column, for example, if 5 units were used on a work order, but only 3 are being requested for a return.  
  
3.  For each work order product to be returned, choose a **Processing Action**. This is the type of return. Choose from the following options:  
  
    -   Create Return to Vendor (RTV)  
  
    -   Return to Warehouse  
  
    -   Change of Equipment Ownership  
  
4.  Next, specify the destination of the return. For example, if your **Processing Action** is **Return to Warehouse**, then in the **Return to Warehouse** column, choose the warehouse the product is going back to.  
  
5.  When you're done, in the **Add WO Products** dialog box, click **Ok**.  
  
<a name="BKMK_3"></a>   
## Step 3: Approve the RMA  
 If you're the approver, open the RMA and verify that the return has been filled in correctly, and approve the RMA. Here are some of the things you may want to do:  
  
-   Verify RMA products are linked to customer equipment records.  
  
-   Decide if RMA products can be returned and if a credit must be issued.  
  
-   Verify the reason for the return from the customer.  
  
-   Arrange shipping and transportation.  
  
-   Mark the RMA as **Approved**.  
  
> [!NOTE]
>  The approval process depends on your company's return policy. The above is a general list to give you an idea of what you might look for when processing a return.  
  
<a name="BKMK_4"></a>   
## Step 4: Create an RMA receipt  
  
1.  In the RMA record, on the top menu, click the drop-down arrow next to the name of the RMA record, and then click **Receipt**.  
  
2.  Click **+Add New RMA Receipt**.  
  
3.  Use the tooltips to help fill in your information:  
  
    -   Give it a **Name**.  
  
    -   In the **Received By** field, choose the person who is handling the receipt.  
  
<a name="BKMK_5"></a>   
## Step 5: Add RMA receipt products  
  
1. From the RMA receipt record, scroll down to the **Products** section.  
  
2. Click **+Add New RMA Receipt Product record**.  
  
3. [!INCLUDE[proc_handy_infotips](../includes/proc-handy-infotips.md)]  
  
4. Enter the **RMA Product** and **Quantity** received.  
  
5. Click **Save**.  
  
<a name="BKMK_6"></a>   
## Step 6: (Optional) Create an RTV  
You only need to create an RTV if the return is going back to the vendor. Once the product is received by the vendor, you will create an RTV.  
  
1.  Go to  the RMA receipt record, and then scroll down to the **Products** section.  
  
2.  In the RMA record, on the command bar at the top, click **Create RTV.** The **Create RTV** dialog box opens.  
  
3.  Review the details, and then select the **Return** check box.  
  
4.  A dialog box opens, confirming the RTV has been created.  
  
5.  To see the RTV record, from the main menu go to **Field Services** > **RTVs**.  
  
6.  Click the RTV record that you created to open the record.  
  
7.  To track the return, mark when it was approved, shipped, and received.  
  
8.  To credit the customer, go to the RMA, and then click **RMA Product**.  
  
9. Set **Credit to Account** to **Yes**.  
  
10. Click **Save**.  
  
11. To issue a credit memo, go back to the RMA, and then to **RMA Receipts**.  
  
12. Click the RMA receipt.  
  
13. On the command bar at the top, click **Credit to Customer**.  

## Ship via

When you create a [!INCLUDE[pn_dyn_365_field_service](../includes/pn-dyn-365-field-service.md)] purchase order in the system, it's a good idea  to track how the order is shipped. This helps you track the purchase order. The ship-via option lets you specify different shipping methods used by your company.  
  
 For example, you might use freight shipping, USPS Ground, or FedEx when products are purchased. In this case, you can specify these shipping methods in the ship-via setting. When you create ship-via methods, you'll see this in the purchase order form.  
  
1.  From the main menu, click **Field Service** > **Administration**, and then choose **Ship Via**.  
  
2.  On the **Active Ship Via** screen, click **+New** in the upper left corner.  
  
3.  Use the tooltips to help you fill in your information, and then click **Save**.  
  
### See also    
 [Configure and set up customer assets](../field-service/configure-set-up-customer-assets.md)   
 [Create a purchase order](../field-service/create-purchase-order.md)   
 [Create an inventory adjustment](../field-service/create-inventory-adjustment.md)   
 [Create an inventory transfer](../field-service/create-inventory-transfer.md)   
 [View product inventory](../field-service/view-product-inventory.md)   
 [Create a return to vendo](../field-service/create-return-vendor.md)<br>

