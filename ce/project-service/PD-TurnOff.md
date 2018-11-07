---
title: Setup pricing dimensions in Project Service (Dynamics 365 for Project Service) | MicrosoftDocs
description: Introduction to setup of pricing dimensions in project service solution 
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


Turn off a pricing dimension, either the out-of-the-box Project Service dimensions such as msdyn_resourcecategory (Role) and msdyn_organizationalunit (Organizational Unit) or any other custom pricing dimension can be done by setting Applicable to Cost and/or Applicable to Sales fields of the Pricing Dimension to “No”
However, doing so will bring up this error message:
This error message indicates that there are previously set up price records for the dimension that is being turned off. It is required that all “role price” and “role price markup” records that refer to a dimension be deleted before the dimension’s applicability can be to set to “No.” This rule applies to both out-of-the-box Project Service pricing dimension and any custom pricing dimension that you may have created.
The reason for this validation is the following:
Project Service has a constraint that each Role price record has a unique combination of dimensions. For instance, let’s say on a Price List called “US Cost Rates 2018,” you have the following Role price rows: Standard Title Org Unit Unit Price Currency
Systems Engineer
Contoso US
Hour
100
USD
Sr. Systems Engineer
Contoso US
Hour
150
USD
Turning off Standard Title as pricing dimension will mean that when Project Service pricing engine searches for a price, it will only use Org Unit value from the Input context. If the Org Unit of the input context is “Contoso US”, the result will be non-deterministic since both the rows will match. Hence, during the creation of Role price records, Project Service validates that the combination of dimensions is unique. This constraint can be violated when dimensions are turned off. Hence it is required that you delete all Role Price and Role Price Markup rows that have that dimension value populated before you turn off a dimension.
