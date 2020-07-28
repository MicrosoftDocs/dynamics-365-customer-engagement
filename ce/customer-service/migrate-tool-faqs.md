---
title: "Migration Tool FAQs | Microsoft Docs"
description: "Migration Tool FAQs"
ms.date: 08/03/2020
ms.service:
  - "dynamics-365-customerservice"
ms.topic: article
author: lerobbin
ms.author: lerobbin
manager: shujoshi
---

# Migration Tool FAQs

Find answers to common questions regarding migration.

<List migration tool faqs here>

## Automatic record creation (ARC) and Service Level Agreement (SLA) Migration Tool FAQs

### Do I need a separate/additional license for Power Automate before running migration?

No separate power automate license required. 

### Can any other user role other than admin run the migration tool? 

Currently, only admins have permissions to run the migration tool. 

### Will the rules be activated post-migration automatically? 

No, the user needs to activate them manually once the migration is complete. 

### What does incomplete status mean? 

If this is in the migration summary, it means that the migration process could not successfully migrate all selected rules. At a rule level this means, that the rule either failed or could not migrate fully. 

### Where is the incompletely migrated rules count tracked in the migration process? 

It get counted as part of pending, as it is not fully migrated. We only consider fully migrated rules as success. 

### Can I activate an ARC/SLA with migration status incomplete? 

No, the toggle has to be set to complete.  We made a change wrt flow activation for migrated slas. The migrated slas will be created in draft state now, and their flows will be turned off by default, they will be activated on activation of the sla.

### Can I activate the migrated rule anytime? 
A migrated rule can only be activated when the mark for complete/ review is toggled on (that's when we consider the rule as success) 

### Will the legacy rule will be de-activated? 

When you activate a migrated rule, the corresponding legacy rule will be de-activated. 

<!--Only for ARC, SLA not the case, they can co-exist and active at the same time-->

### What if I have custom forms or fields for ARC or SLA (Customizations) 

We only support OOB fields and attributes. Custom fields and configurations are not supported as part of migration process. 

### What do I do if the rule has migrated partially? 

You always have the option to edit/fix the web rule based on the type of error and retry the migration. again. 

### How do I retry migration for a specific rule? 

If you're retrying an incompletely migrated rule, you just need to re-select the same rule again when you run the migration tool again. It will automatically replace the existing failed/incomplete rule with the newly migrated one. 

But if you're trying to migrated an already successfully migrated rule, then you need to delete the migrated rule in the UCI version before retrying migration of that rule through the tool. 

### Known condition conversions issues:

### Related entities only in first level are supported, so the user would have to remove any related entity in nesting and re-migrate 

More fetch xml 

<!--Engineering to elaborate further with snapshot, work with Deepa> - covered as part of below snapshot #2 & #3 -->

### For DateType, not on does not work. 
The User can change the legacy SLA item from {not-on selecteddate} to { selecteddate less than and selecteddate greater than), it will work fine  

<!--Engg to elaborate further with snapshot, work with Deepa, get the link from RR and current UCI issues. As this is a known UCI issue> - covered as part of below snapshot #5 -->

### DateTime will be a control and not a calendar. Input should be in specific format 

Date format moved from calendar pick to input model (based on eg shown in text box) 

<!-- Engg to elaborate further with snapshot, work with Deepa>  - covered as part of below snapshot #1-->

See note in the [Create routing rule sets to automatically route cases](https://docs.microsoft.com/en-us/dynamics365/customer-service/create-rules-automatically-route-cases#create-routing-rule-sets-to-automatically-route-cases)

### "Under" field restrictions in UCI  

Any condition which has Lookup with "under" or "not-under" operator will be translated as Related Entity after migration 

Legacy view: 
![Legacy view](media\arc-sla-faq-1.PNG)

UCI View 
![Legacy view](media\arc-sla-faq-2.PNG)

Known issue: currently "under" and "not-under" operator will be shown as blank in UCI after migration and user can't edit (this is same behavior as current GA version of RR, Please check if this was documented by Deepa.) - covered as part of below snapshot #6 

See [documentation link](https://docs.microsoft.com/en-us/dynamics365/customer-service/create-rules-automatically-route-cases) 

## Known SLA issues: 

### Can I re-migrate an activated sla? 

Once activated and linked to another entity (like case) or in use, the migrated rules can't be deleted. We don't support re-migrating the sla again. 

A re-migration attempts to delete the existing migrated sla and creates another sla in the re-attempt. There is a limitation with UC slas, where, if they're once associated with a case/ any other entity, the deletion of the sla is not possible, which is why, the migration can't be re-attempted once the sla is activated and applied. 
 <!-- Engg to elaborate further> Different from ARC. ARC works as expected. -->

 ### Can I migrate the deprecated "standard" SLAs? 

WE support migration of enhanced SLAs only. Since standard SLAs have been deprecated, we do not support the migration of these SLAs at this time. For more information on this, please visit this link:  

See [document link ](https://docs.microsoft.com/en-us/power-platform/important-changes-coming#standard-slas-in-dynamics-365-customer-service-are-deprecated) 

### When does flow get turned on for SLA? 
When the user clicks 'Activate SLA', the corresponding flows get activated. The difference the user would notice in migrated vs uc slas is in the performance of the 'activate sla' button. For UC SLAs, the activate is quick as the corrresponding flows are pre-activated. For migrated slas, the activate would be slower as the flow activation will happen here. 

<!--Engg to elaborate further, do we need to have it?-->

## Known Flow issues: 

### Flow issue pertaining to send email/send email using template 

Currently flow migration is not supporting slugs (dynamics values) in the to/cc/bcc and other user lookup fields. 

<!-- Engg to respond>, For this issue, you need to manually fix the flow as it will show success. Within send email cc, bcc, fields will be empty but will not any exceptions or failure. <Mengyao to work with Sudeep for a more generic platform level message--> 

### See Also
<li></li>