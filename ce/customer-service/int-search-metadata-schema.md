---
title: Develop metadata mapping schema for knowledge articles (preview)
description: Concept description 
author: gandhamm 
ms.author: mgandham 
ms.reviewer: neeranelli
ms.topic: conceptual 
ms.date: 03/01/2023
ms.custom: bap-template 
---

# Develop metadata mapping schema for knowledge articles (preview)

This article describes the schema details required to map information from external data providers to the knowledge article entities, and how you can prepare your own schema mapping JSON file using various fields and attributes.

### Fields

The following table lists the fields and field details that you must use in your JSON schema.

|Field name  |Definition   |Required |Value |
|----------|-----------|------------|----------|
|Name     |Name of the field definition |No     |A string indicating the name of the field. |
|UniqueTargetFieldName     |s the unique identifier or alternate key of the knowledge article entity. Typically, this field is the ID on the content provider side. |Yes     |A string indicating the name of the field. |
|ContentTargetFieldName     | Is the logical name of the attribute to be used. |Yes     |Set the value to “content”. |
|ApiPathLeafName     |Field value should not be changed. |Yes     |Set the value to “knowledgearticles”. |
|List<FieldDefinitions>    |Is a list of field definitions. |Yes     |A set of definitions for the fields. See the following table for the list of supported fields for setting field definitions. |



<!--add your content here-->

<!--Next steps - Required. Provide at least one next step and no more than three. Include some context so the customer can determine why they would click the link.-->
## Next steps

<!--Remove all the comments in this template before you sign-off or merge to the main branch.-->
