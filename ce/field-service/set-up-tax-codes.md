---
title: "Set up tax codes (Dynamics 365 Field Service) | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 09/30/2017
ms.reviewer: 
ms.service: dynamics-365-customerservice
ms.suite: 
ms.technology: 
  - field-service
ms.tgt_pltfrm: 
ms.topic: article
author: krbjoran
ms.assetid: 90d7fdc1-afa0-4ab4-a7c4-87c038709184
caps.latest.revision: 16
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
# Set up tax codes (Field Service)

Set up tax codes in Dynamics 365 Field Service and specify how much tax will be applied to your products, agreements, and services.  
  
Each tax code may contain multiple child tax codes; in that case, the tax rate will be determined by the total of all children.  
  
If an area has more than one type of tax, for example, state and county tax, then use the **Tax Group** option to combine several tax codes into one group.  
  
For example, if the state of California has a state and county tax, then you might have a tax group called "California, Alameda County." The tax group will have two tax codes: one for overall California state tax and one for Alameda County local tax.  
  
1.  From the main menu, click **Field Services** > **Administration**, and then choose **Tax Codes**.  
  
2.  On the **Active Tax Codes** screen, click **+New** in the upper left corner.  
  
3.  Use the tooltips to help fill in your information, and then click **Save**.  
  
4.  If **Act as tax Group** is set to **Yes**, then do this:  
  
    1.  Go to the **Tax Code Details** section and click **+Add Tax Code Detail record**.  
  
    2.  Specify the **Tax Code**.  
  
    3.  If the government agency charges tax above the local tax then set **Tax on tax** to **Yes**.  
  
         For example, the Canadian government charges Provincial Sales Tax (PST) and Goods and Services Tax (GST). In this case, you will need to set a tax on tax.  
  
         For instance, if the work order total equals $100,  the first tax code in the group is calculated on the $100. If the tax code is 5% then the total is now $105. If the second code in the tax group is 10%, and it is marked as a tax on tax, this 10% is calculated on $105 instead of $100, which makes the total $110. However, if this second code is not flagged as a tax on tax, then the 10% is calculated on the initial work order amount, of $100.  
  
    4.  In the **Line Order** field, enter the order of how the system should calculate the multiple tax codes.  
  
    5.  Save **Save**.  
  
### See also    
 [Overview of Dynamics 365 Field Service](../field-service/overview.md)   
 [Set up customer agreements](../field-service/set-up-customer-agreements.md)   
 [Set up agreement sub-statuses](../field-service/set-up-agreement-sub-statuses.md)   
 [User's Guide](../field-service/user-guide.md)
