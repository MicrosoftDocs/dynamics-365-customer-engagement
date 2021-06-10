---
title: "Link custom attributes of the recurring appointment master and appointment entities (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "Link the custom attributes of the RecurringAppointmentMaster entity with custom attributes of the Appointment entity to automatically copy data."
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
helpviewer_keywords: 
  - "custom attributes, 1:1 mapping between"
  - schedule and appointment entities, linking custom attributes of a recurring appointment master (series)
  - linking custom attributes of a recurring appointment master (series)
  - schedule and appointment entities, custom attributes of a recurring appointment master
  - custom attributes, affect of field-level security on
ms.assetid: 0480c355-6954-472c-8c9e-2129a3684364
caps.latest.revision: 18
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Link custom attributes of the recurring appointment master and appointment entities

You can link the custom attributes created for the `RecurringAppointmentMaster` entity with the custom attributes created for the `Appointment` entity to automatically copy the data from the recurring appointment master custom attribute to the linked recurring appointment instances custom attribute, every time it is expanded.  
  
 There is a 1:1 mapping between the custom attributes, which implies that a custom attribute of the recurring appointment master entity can be linked to only one custom attribute of the appointment entity. Moreover, the custom attributes that are to be linked together must be of the same type. For example, you cannot link a custom attribute of type `string` with a `decimal` custom attribute. For information about different types of attributes, see [Customize Entity Attribute Metadata](customize-entity-attribute-metadata.md).  
  
> [!NOTE]
>  You cannot link the custom attributes that have *field-level security* enabled. Similarly, you cannot enable field-level security for linked custom attributes.  
  
### Link custom attributes  
  
1. Create a custom attribute for the appointment entity using the <xref:Microsoft.Xrm.Sdk.Messages.CreateAttributeRequest> class.  
  
2. Create a custom attribute for the recurring appointment series (recurring appointment master) entity. While specifying the attribute metadata for the custom attribute, use the <xref:Microsoft.Xrm.Sdk.Metadata.AttributeMetadata>.<xref:Microsoft.Xrm.Sdk.Metadata.AttributeMetadata.LinkedAttributeId> property to link to the custom attribute that you created in step 1.  
  
3. Publish the changes to the solution.  
  
   For sample code, see [Sample: Link Custom Attributes between Series and Instances](sample-link-custom-attributes-between-series-instances.md).  
  
### See also

 [Recurring Appointment Entities](recurring-appointment-entities.md)   
 [RecurringAppointmentMaster Entity](entities/recurringappointmentmaster.md)   
 [Sample: Link Custom Attributes between Series and Instances](sample-link-custom-attributes-between-series-instances.md)   
 [Customize Entity Attribute Metadata](customize-entity-attribute-metadata.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]