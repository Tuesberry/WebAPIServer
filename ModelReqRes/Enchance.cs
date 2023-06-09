﻿using System.ComponentModel.DataAnnotations;
using TuesberryAPIServer.ModelDb;

namespace TuesberryAPIServer.ModelReqRes
{
    public class PkEnchanceRequest
    {
        [Required(ErrorMessage = "Required")]
        public Int32 UserItemId { get; set; } = 0;

        [Required(ErrorMessage = "Required")]
        [StringLength(15, MinimumLength = 4, ErrorMessage = "Id length is not appropriate")]
        public string Id { get; set; } = string.Empty;

        [Required(ErrorMessage = "Required")]
        public string AuthToken { get; set; } = string.Empty;

        [Required(ErrorMessage = "Required")]
        public string AppVersion { get; set; } = string.Empty;

        [Required(ErrorMessage = "Required")]
        public string MasterDataVersion { get; set; } = string.Empty;
    }

    public class PkEnchanceResponse
    {
        public ErrorCode Result { get; set; } = ErrorCode.None;
        public bool IsSuccess { get; set; } = false;
        public ItemData? EnchanceItemData { get; set; }
    }
}
