---
title: "Set up tax codes (Dynamics 365 Field Service) | MicrosoftDocs"
description: Learn how to set up tax codes in Dynamics 365 Field Service
ms.custom: 
  - dyn365-fieldservice
ms.date: 09/30/2017
ms.reviewer: krbjoran
ms.service: dynamics-365-customerservice 
ms.topic: article
author: FieldServiceDave
ms.author: daclar
manager: shellyha
search.app: 
  - D365CE
  - D365FS
---
# Set up tax codes (Field Service)

Set up tax codes in Dynamics 365 Field Service and specify how much tax will be applied to your products, agreements, and services.  
  
Each tax code may contain multiple child tax codes; in that case, the tax rate will be determined by the total of all children.  
  
If an area has more than one type of tax, for example, state and county tax, then use the **Tax Group** option to combine several tax codes into one group.  
  
For example, if the state of California has a state and county tax, then you might have a tax group called "California, Alameda County." The tax group will have two tax codes: one for overall California state tax and one for Alameda County local tax.  
  
1.  From the main menu, go **Field Services** > **Administration**, and then choose **Tax Codes**.  
  
2.  On the **Active Tax Codes** screen, select **+New** in the upper left corner.  
  
3.  Use the tooltips to help fill in your information, and then select **Save**.  
  
4.  If **Act as tax Group** is set to **Yes**:  
  
    1.  Go to the **Tax Code Details** section and select **+Add Tax Code Detail record**.  
  
    2.  Specify the **Tax Code**.  
  
    3.  If the government agency charges tax above the local tax then set **Tax on tax** to **Yes**.  
  
         For example, the Canadian government charges Provincial Sales Tax (PST) and Goods and Services Tax (GST). You will need to set a tax on tax.  
  
         For instance, if the work order total equals $100,  the first tax code in the group is calculated on the $100. If the tax code is 5%, then the total is now $105. If the second code in the tax group is 10%, and it is marked as a tax on tax, the 10% is calculated on $105 instead of $100, which makes the total $110. However, if the second code is not flagged as a tax on tax, then the 10% is calculated on the initial work order amount, of $100.  
  
    4.  In the **Line Order** field, enter the order of how the system should calculate the multiple tax codes.  
  
    5.  Select **Save**.  
  
### See also

- [Overview of Dynamics 365 Field Service](../field-service/overview.md)   
- [Set up customer agreements](../field-service/set-up-customer-agreements.md)   
- [Set up agreement substatuses](../field-service/set-up-agreement-sub-statuses.md)   
- [User's guide](../field-service/user-guide.md)
