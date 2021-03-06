using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     KoubeiMarketingCampaignActivityOfflineResponse.
	/// </summary>
	public class KoubeiMarketingCampaignActivityOfflineResponse : AopResponse
	{
		/// <summary>
		///     活动子状态，如审核中
		/// </summary>
		[JsonProperty("audit_status")]
		public string AuditStatus { get; set; }

		/// <summary>
		///     活动状态
		/// </summary>
		[JsonProperty("camp_status")]
		public string CampStatus { get; set; }
	}
}