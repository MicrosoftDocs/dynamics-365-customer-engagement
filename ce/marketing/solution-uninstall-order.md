---
title: "Dynamics 365 Marketing solution uninstall order (Dynamics 365 Marketing) | Microsoft Docs"
description: "Lists the correct order in which to remove solutions when uninstalling Dynamics 365 Marketing."
ms.date: 07/28/2021
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-admin
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
manager: shellyha
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Solution uninstall order for removing Dynamics 365 Marketing

> [!NOTE]
> If you want to release your Marketing entitlement to use on a different instance, you **do not** need to uninstall any of the Marketing solutions.

To delete Dynamics 365 from an instance, first open the Marketing setup wizard and run the uninstall command. The uninstall command releases your Dynamics 365 license and disconnects the Marketing services. If you'd also like to remove all of the related solutions from your instance, you must manually delete them in the order listed below. (Some of the items listed here may not be present on your instance, so just skip any missing items.) For complete instructions, see [Uninstall Marketing](uninstall-marketing.md).

Moments-based marketing:

1. DynamicsMKT_AnchorSolution
1. DynamicsMKT_CxpApplicationUser
1. DynamicsMKT_CIConnection
1. DynamicsMKT_Roles
1. msdyn_InsightsAnalyticsMKTAnalytics
1. msdyn_InsightsAnalyticsMKTConfiguration
1. msdyn_DataInsightsAndAnalyticsForMKT
1. DynamicsMKT_Configuration
1. DynamicsMKT_CustomerVoiceIntegration
1. DynamicsMKT_StandaloneSitemap
1. DynamicsMKT_Sitemap
1. DynamicsMKT_CxpGetStartedExperience
1. DynamicsMKT_PushNotification
1. DynamicsMKT_EmailChannel
1. DynamicsMKT_CxpEmailEditor
1. DynamicsMKT_CxpEmailEditorCanvas
1. DynamicsMKT_EmailEditorCanvasShared
1. DynamicsMKT_EmailEditorShared
1. DynamicsMKT_PersonalizationUI
1. DynamicsMKT_CxpCmsIntegration
1. DynamicsMKT_SmsChannel
1. DynamicsMKT_OrchestrationAnalytics
1. DynamicsMKT_CxpOrchestrationUI
1. DynamicsMKT_Consent
1. DynamicsMKT_AssetControlsSolution
1. DynamicsMKT_CxpFormControls
1. DynamicsMKT_OrchestrationEngineAttachCI
1. DynamicsMKT_OrchestrationEngine
1. DynamicsMKT_FeatureConfiguration
1. DynamicsMKT_BaseSolution
1. DynamicsMKT_SharedMarketingControls
1. MicrosoftDynamics_ContentEditor

Segment-based marketing:

1.	MicrosoftDynamics_MktCompleteAnchorSolution
2.	MicrosoftDynamics_MarketingAppRoles
3.	LeadGenAppUser
4.	MicrosoftDynamics_MarketingAppUser
5.	MicrosoftDynamics_SubscriptionList_patch
6.	MicrosoftDynamics_SubscriptionList
7.	MicrosoftDynamics_OrgCleanup_patch
8.	MicrosoftDynamics_OrgCleanup
9.	MicrosoftDynamics_PackageUpgrade_patch
10.	MicrosoftDynamics_PackageUpgrade
11.	MicrosoftDynamics_PersonalizedPages_patch
12.	MicrosoftDynamics_PersonalizedPages
13.	MicrosoftDynamics_MarketableContactSupport_patch
14.	MicrosoftDynamics_MarketableContactSupport
15.	MicrosoftDynamics_MarketingFormsProLink_patch
16.	MicrosoftDynamics_MarketingFormsProLink
17.	MicrosoftDynamics_MktVocIntegration_patch
18.	MicrosoftDynamics_MktVocIntegration
19.	MicrosoftDynamics_EvtMgmtVocLink_patch
20.	MicrosoftDynamics_EvtMgmtVocLink
21.	MicrosoftDynamics_MktVocLink_patch
22.	MicrosoftDynamics_MktVocLink
23.	MicrosoftDynamics_MktPortalsLink_patch
24.	MicrosoftDynamics_MktPortalsLink
25.	MicrosoftDynamics_EvtMgmtPortalsLink_patch
26.	MicrosoftDynamics_EvtMgmtPortalsLink
27.	MicrosoftDynamics_MktContentSuggestions
28.	MicrosoftDynamics_EmailEditorModule
29.	MicrosoftDynamics_EmailEditorCanvasModule
30.	MicrosoftDynamics_QuickSend_patch
31.	MicrosoftDynamics_QuickSend
32.	MicrosoftDynamics_ABTesting_patch
33.	MicrosoftDynamics_ABTesting
34.	MicrosoftDynamics_GwennolSegmentBooster_patch
35.	MicrosoftDynamics_GwennolSegmentBooster
36.	MicrosoftDynamics_GwennolFeatureConfiguration_patch
37.	MicrosoftDynamics_GwennolFeatureConfiguration
38.	MicrosoftDynamics_GwennolSpamScore_patch
39.	MicrosoftDynamics_GwennolSpamScore
40.	MicrosoftDynamics_GwennolOESTPrediction_patch
41.	MicrosoftDynamics_GwennolOESTPrediction
42.	MicrosoftDynamics_GwennolOptimalEmailSendingTime_patch
43.	MicrosoftDynamics_GwennolOptimalEmailSendingTime
44.	MicrosoftDynamics_MktIntegration_patch
45.	MicrosoftDynamics_MktIntegration
46.	MicrosoftDynamics_SocialPosting_patch
47.	MicrosoftDynamics_SocialPosting
48.	MicrosoftDynamics_SocialEngagement_patch
49.	MicrosoftDynamics_SocialEngagement
50.	MicrosoftDynamics_LinkedInMatchedAudiences_patch
51.	MicrosoftDynamics_LinkedInMatchedAudiences
52.	MicrosoftDynamics_MktLeadGenLink_patch
53.	MicrosoftDynamics_MktLeadGenLink
54.	MicrosoftDynamics_MktConsentManagement_patch
55.	MicrosoftDynamics_MktConsentManagement
56.	MicrosoftDynamics_FeatureConfiguration_patch
57.	MicrosoftDynamics_FeatureConfiguration
58.	MicrosoftDynamics_MktQuotaInfo_patch
59.	MicrosoftDynamics_MktQuotaInfo
60.	MicrosoftDynamics_MktPageTemplates_patch
61.	MicrosoftDynamics_MktPageTemplates
62.	MicrosoftDynamics_MktEvtMgmtLink_patch
63.	MicrosoftDynamics_MktEvtMgmtLink
64.	MicrosoftDynamics_MktOrchestrationCompatModule
65.	MicrosoftDynamics_MarketingOrchestrationModule
66.	LinkedInLeadGenIntegration_patch
67.	LinkedInLeadGenIntegration
68.	MicrosoftDynamics_MktLeadManagement_patch
69.	MicrosoftDynamics_MktLeadManagement
70.	MicrosoftDynamics_MktEmailTemplates_patch
71.	MicrosoftDynamics_MktEmailTemplates
72.	MicrosoftDynamics_Marketing_patch
73.	MicrosoftDynamics_Marketing
74.	MicrosoftDynamics_EventManagement_patch
75.	MicrosoftDynamics_EventManagement
76.	MicrosoftDynamics_ReusableBlocks_patch
77.	MicrosoftDynamics_ReusableBlocks
78.	MicrosoftDynamics_DigitalAssets_patch
79.	MicrosoftDynamics_DigitalAssets
80.	MicrosoftDynamics_Calendar_patch
81.	MicrosoftDynamics_Calendar
82.	MicrosoftDynamics_HealthChecker_patch
83.	MicrosoftDynamics_HealthChecker
84.	MicrosoftDynamics_SegmentationDataLake

If you see any other "anchor" solutions that start with "MicrosoftDynamics_", you can delete these too. They are probably left over from an earlier version that you upgraded. You can remove these in any order after you've uninstalled the other solutions.

Marketing application dependencies are installed alongside the Marketing application. The following dependencies can only be uninstalled if they are not used by other solutions:

1. msdyn_DataInsightsAndAnalytics: Enables analytics capabilities for Dynamics 365 applications like Customer Service, Field Service, and Universal Resource Scheduling.
1. DynamicsMKT_Segmentation: Standard entity of segment representation and segment metadata.

[!INCLUDE[footer-include](../includes/footer-banner.md)]