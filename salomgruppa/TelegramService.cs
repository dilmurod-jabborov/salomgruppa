using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Telegram.Bot;

public class TelegramService
{
    private readonly TelegramBotClient botClient;
    private readonly long chatId;

    public TelegramService(string token, long chatId)
    {
        botClient = new TelegramBotClient(token);
        this.chatId = chatId;
    }

    public async Task SendTelegramMessage(string text)
    {
        try
        {
            await botClient.SendTextMessageAsync(chatId, text);
            Console.WriteLine("✅ Xabar yuborildi!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"❌ Xatolik: {ex.Message}");
        }
    }
}

