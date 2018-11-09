---
title: Default pricing dimensions in Project Service (Dynamics 365 for Project Service) | MicrosoftDocs
description: Understanding out-of-the-box pricing dimensions in project service solution 
author: Rumant
manager: eichimur
ms.custom:
  - dyn365-projectservice
ms.date: 11/06/2018
ms.topic: article
ms.prod: Project Service
ms.service: business-applications
ms.author: rumant
audience: Admin
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
    - D365PS
---

# Understanding default pricing dimensions in the Project Service Solution

Project Service ships with a default set of pricing dimensions. You can verify this by navigating to Project Service -> Parameters and 
open the parameter record and click on the tab “Amount-based pricing dimensions”. Role represented as “msdyn_resourcecategory” and Resourcing Organizational Unit represented as “msdyn_organizationalunit” are entries in the table and they have the fields “Applicable to sales” and “Applicable to cost” set to yes. “msdyn_resourcecategory” and “msdyn_organizationalunit” are the field names of Role and Organizational Unit respectively. 
This means that Project Service Pricing allows the setup of prices and costs for each Role and Organizational Unit combination by default.

![Screenshot of Project Service parameters with “Applicable to Sales” highlighted](media/PS-OOB-parameters.png)

**For customers of Project Service that have been using these out-of-the box fields of role and organizational unit as pricing dimensions
before this feature was released, there will not be any observable change. They can continue to use Project Service as usual. 
If, however, you see the need to price or cost for your resources using any other additional attribute,
then the below sections of this document will help explain that process.**
