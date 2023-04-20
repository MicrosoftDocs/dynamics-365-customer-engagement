---
title: "Dynamics 365 Marketing solution uninstall order (Dynamics 365 Marketing) | Microsoft Docs"
description: "Lists the correct order in which to remove solutions when uninstalling Dynamics 365 Marketing."
ms.date: 10/19/2022
ms.custom: 
  - dyn365-admin
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
search.audienceType: 
  - admin
  - customizer
  - enduser
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
1. DynamicsMKT_TeamsVEvents
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

1. MicrosoftDynamics_MktCompleteAnchorSolution
1. MicrosoftDynamics_MarketingAppRoles
1. LeadGenAppUser
1. MicrosoftDynamics_MarketingAppUser
1. MicrosoftDynamics_SubscriptionList_patch
1. MicrosoftDynamics_SubscriptionList
1. MicrosoftDynamics_OrgCleanup_patch
1. MicrosoftDynamics_OrgCleanup
1. MicrosoftDynamics_PackageUpgrade_patch
1. MicrosoftDynamics_PackageUpgrade
1. MicrosoftDynamics_PersonalizedPages_patch
1. MicrosoftDynamics_PersonalizedPages
1. MicrosoftDynamics_MarketableContactSupport_patch
1. MicrosoftDynamics_MarketableContactSupport
1. MicrosoftDynamics_MarketingFormsProLink_patch
1. MicrosoftDynamics_MarketingFormsProLink
1. MicrosoftDynamics_MktVocIntegration_patch
1. MicrosoftDynamics_MktVocIntegration
1. MicrosoftDynamics_EvtMgmtVocLink_patch
1. MicrosoftDynamics_EvtMgmtVocLink
1. MicrosoftDynamics_MktVocLink_patch
1. MicrosoftDynamics_MktVocLink
1. MicrosoftDynamics_MktPortalsLink_patch
1. MicrosoftDynamics_MktPortalsLink
1. MicrosoftDynamics_EvtMgmtPortalsLink_patch
1. MicrosoftDynamics_EvtMgmtPortalsLink
1. MicrosoftDynamics_MktContentSuggestions
1. MicrosoftDynamics_QuickSend_patch
1. MicrosoftDynamics_QuickSend
1. MicrosoftDynamics_ABTesting_patch
1. MicrosoftDynamics_ABTesting
1. MicrosoftDynamics_GwennolSegmentBooster_patch
1. MicrosoftDynamics_GwennolSegmentBooster
1. MicrosoftDynamics_GwennolFeatureConfiguration_patch
1. MicrosoftDynamics_GwennolFeatureConfiguration
1. MicrosoftDynamics_GwennolSpamScore_patch
1. MicrosoftDynamics_GwennolSpamScore
1. MicrosoftDynamics_GwennolOESTPrediction_patch
1. MicrosoftDynamics_GwennolOESTPrediction
1. MicrosoftDynamics_GwennolOptimalEmailSendingTime_patch
1. MicrosoftDynamics_GwennolOptimalEmailSendingTime
1. MicrosoftDynamics_MktIntegration_patch
1. MicrosoftDynamics_MktIntegration
1. MicrosoftDynamics_SocialPosting_patch
1. MicrosoftDynamics_SocialPosting
1. MicrosoftDynamics_SocialEngagement_patch
1. MicrosoftDynamics_SocialEngagement
1. MicrosoftDynamics_LinkedInMatchedAudiences_patch
1. MicrosoftDynamics_LinkedInMatchedAudiences
1. MicrosoftDynamics_MktLeadGenLink_patch
1. MicrosoftDynamics_MktLeadGenLink
1. MicrosoftDynamics_MktConsentManagement_patch
1. MicrosoftDynamics_MktConsentManagement
1. MicrosoftDynamics_FeatureConfiguration_patch
1. MicrosoftDynamics_FeatureConfiguration
1. MicrosoftDynamics_MktQuotaInfo_patch
1. MicrosoftDynamics_MktQuotaInfo
1. MicrosoftDynamics_MktPageTemplates_patch
1. MicrosoftDynamics_MktPageTemplates
1. MicrosoftDynamics_MktEvtMgmtLink_patch
1. MicrosoftDynamics_MktEvtMgmtLink
1. MicrosoftDynamics_MktOrchestrationCompatModule
1. MicrosoftDynamics_MarketingOrchestrationModule
1. LinkedInLeadGenIntegration_patch
1. LinkedInLeadGenIntegration
1. MicrosoftDynamics_MktLeadManagement_patch
1. MicrosoftDynamics_MktLeadManagement
1. MicrosoftDynamics_MktEmailTemplates_patch
1. MicrosoftDynamics_MktEmailTemplates
1. MicrosoftDynamics_Marketing_patch
1. MicrosoftDynamics_Marketing
1. MicrosoftDynamics_EventManagement_patch
1. MicrosoftDynamics_EventManagement
1. MicrosoftDynamics_ReusableBlocks_patch
1. MicrosoftDynamics_ReusableBlocks
1. MicrosoftDynamics_DigitalAssets_patch
1. MicrosoftDynamics_DigitalAssets
1. MicrosoftDynamics_Calendar_patch
1. MicrosoftDynamics_Calendar
1. MicrosoftDynamics_HealthChecker_patch
1. MicrosoftDynamics_HealthChecker
1. MicrosoftDynamics_SegmentationDataLake

If you see any other "anchor" solutions that start with "MicrosoftDynamics_", you can delete these too. They are probably left over from an earlier version that you upgraded. You can remove these in any order after you've uninstalled the other solutions.

Marketing application dependencies are installed alongside the Marketing application. The following dependencies can only be uninstalled if they are not used by other solutions:

1. msdyn_DataInsightsAndAnalytics: Enables analytics capabilities for Dynamics 365 applications like Customer Service, Field Service, and Universal Resource Scheduling.
1. DynamicsMKT_Segmentation: Standard entity of segment representation and segment metadata.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
