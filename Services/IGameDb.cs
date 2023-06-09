﻿using TuesberryAPIServer.ModelDb;

namespace TuesberryAPIServer.Services
{
    public interface IGameDb : IDisposable
    {
        // --------- Game Data --------- //
        public Task<Tuple<ErrorCode, Int64>> CreateGameData(string userId);
        
        public Task<Tuple<ErrorCode, GameData, Int64>> LoadGameData(string userId);

        public Task<ErrorCode> UpdateMoney(Int64 accountId, Int32 amount);

        public Task<ErrorCode> UpdateStage(Int64 accountId, Int32 stageNum);

        public Task<Tuple<ErrorCode, Int32, Int32>> LoadLevelAndExp(Int64 accountId);

        public Task<ErrorCode> UpdateLevelAndExp(Int64 accountId, Int32 level, Int32 exp);

        public Task<Tuple<ErrorCode, Int32>> LoadFinalCompletedStageNum(Int64 accountId);

        public Task<ErrorCode> DeleteGameData(string userId);

        // --------- Item Data --------- //
        public Task<ErrorCode> CreateDefaultItemData(Int64 accountId);

        public Task<Tuple<ErrorCode, List<ItemData>>> LoadItemData(Int64 accountId);

        public Task<Tuple<ErrorCode, ItemData>> LoadItemData(Int64 accountId, Int32 userItemId);

        public Task<ErrorCode> InsertItem(Int64 accountId, ItemData itemData);

        public Task<ErrorCode> InsertItem(Int64 accountId, List<ItemData> itemDataList);

        public Task<ErrorCode> InsertOrUpdateItem(Int64 accountId, ItemData itemData);

        public Task<ErrorCode> InsertOrUpdateItem(Int64 accountId, List<ItemData> itemDataList);

        public Task<ErrorCode> UpdateItem(Int64 accountId, ItemData itemData);

        public Task<ErrorCode> UpdateItemAmount(Int64 accountId, ItemData itemData);

        public Task<ErrorCode> DeleteOrUpdateItem(Int64 accountId, List<ItemData> itemDataList);

        public Task<ErrorCode> DeleteItem(Int64 accountId, Int32 userItemId);

        public Task<ErrorCode> DeleteItem(Int64 accountId, List<Int32> userItemIdList);

        // --------- Mailbox --------- //

        public Task<Tuple<ErrorCode, List<MailboxData>>> LoadMailList(Int64 accountId, Int32 page);

        public Task<Tuple<ErrorCode, string>> LoadMailDetail(Int64 accountId, Int32 mailId);

        public Task<Tuple<ErrorCode, List<MailboxItemData>>> LoadMailItemList(Int32 mailId);

        public Task<ErrorCode> ReceiveMailItem(Int64 accountId, Int32 mailId);

        public Task<ErrorCode> SetMailRead(Int64 accountId, Int32 mailId, bool isRead = true);

        public Task<ErrorCode> SetMailReceived(Int64 accountId, Int32 mailId, bool isReceived = true);

        public Task<ErrorCode> DeleteMail(Int64 accountId, Int32 mailId);

        public Task<bool> IsValidMailId(Int64 accountId, Int32 mailId);
        
        public Task<bool> IsValidAndNotReadMailId(Int64 accountId, Int32 mailId);

        public Task<bool> IsValidAndNotReceivedMailId(Int64 accountId, Int32 mailId);

        public Task<Tuple<ErrorCode, Int32>> InsertMail(Int64 accountId, MailboxData mailData, string comment);

        // --------- Attendance --------- //

        public Task<ErrorCode> CreateAttendanceData(Int64 accountId);
        
        public Task<Tuple<ErrorCode, AttendanceData>> LoadAttendanceData(Int64 accountId);

        public Task<ErrorCode> UpdateAttendanceData(Int64 accountId, AttendanceData attendanceData);

        // --------- Payment --------- //

        public Task<Tuple<ErrorCode, bool>> IsDuplicatePayment(Int64 accountId, string orderNumber, DateTime purchaseDate);

        public Task<ErrorCode> InsertPaymentData(Int64 accountId, string orderNumber, DateTime purchaseDate, Int32 productCode);

    }
}
