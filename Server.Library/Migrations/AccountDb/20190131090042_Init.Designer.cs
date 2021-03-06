﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Server.MirDatabase;

namespace Server.Migrations.AccountDb
{
    [DbContext(typeof(AccountDbContext))]
    [Migration("20190131090042_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028");

            modelBuilder.Entity("Server.MirDatabase.AccountInfo", b =>
                {
                    b.Property<int>("Index")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AccountID");

                    b.Property<bool>("AdminAccount");

                    b.Property<string>("BanReason");

                    b.Property<bool>("Banned");

                    b.Property<DateTime>("BirthDate");

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("CreationIP");

                    b.Property<uint>("Credit");

                    b.Property<string>("EMailAddress");

                    b.Property<DateTime>("ExpandedStorageExpiryDate");

                    b.Property<DateTime>("ExpiryDate");

                    b.Property<uint>("Gold");

                    b.Property<bool>("HasExpandedStorage");

                    b.Property<DateTime>("LastDate");

                    b.Property<string>("LastIP");

                    b.Property<string>("Password");

                    b.Property<string>("SecretAnswer");

                    b.Property<string>("SecretQuestion");

                    b.Property<string>("StorageString");

                    b.Property<string>("UserName");

                    b.Property<int>("WrongPasswordCount");

                    b.HasKey("Index");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("Server.MirDatabase.AuctionInfo", b =>
                {
                    b.Property<ulong>("AuctionID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CharacterIndex");

                    b.Property<DateTime>("ConsignmentDate");

                    b.Property<bool>("Expired");

                    b.Property<ulong>("ItemUniqueID");

                    b.Property<uint>("Price");

                    b.Property<bool>("Sold");

                    b.HasKey("AuctionID");

                    b.ToTable("Auctions");
                });

            modelBuilder.Entity("Server.MirDatabase.CharacterInfo", b =>
                {
                    b.Property<int>("Index")
                        .ValueGeneratedOnAdd();

                    b.Property<byte>("AMode");

                    b.Property<int>("AccountInfoIndex");

                    b.Property<bool>("AllowGroup");

                    b.Property<bool>("AllowTrade");

                    b.Property<string>("BanReason");

                    b.Property<bool>("Banned");

                    b.Property<string>("BindLocationString");

                    b.Property<int>("BindMapIndex");

                    b.Property<byte[]>("BuffsBytes");

                    b.Property<DateTime>("ChatBanExpiryDate");

                    b.Property<bool>("ChatBanned");

                    b.Property<byte>("Class");

                    b.Property<long>("CollectTime");

                    b.Property<string>("CompletedQuestsString");

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("CreationIP");

                    b.Property<bool>("CrossHalfMoon");

                    b.Property<string>("CurrentLocationString");

                    b.Property<int>("CurrentMapIndex");

                    b.Property<byte[]>("CurrentQuestsBytes");

                    b.Property<ulong>("CurrentRefineItemIndex");

                    b.Property<DateTime>("DeleteDate");

                    b.Property<bool>("Deleted");

                    b.Property<byte>("Direction");

                    b.Property<bool>("DoubleSlash");

                    b.Property<string>("EquipmentString");

                    b.Property<long>("Experience");

                    b.Property<DateTime>("ExpiryDate");

                    b.Property<string>("FlagsString");

                    b.Property<byte[]>("FriendsBytes");

                    b.Property<byte>("Gender");

                    b.Property<int>("GuildIndex");

                    b.Property<ushort>("HP");

                    b.Property<byte>("Hair");

                    b.Property<bool>("HalfMoon");

                    b.Property<bool>("HasRentedItem");

                    b.Property<byte[]>("IntelligentCreaturesBytes");

                    b.Property<string>("InventoryString");

                    b.Property<DateTime>("LastDate");

                    b.Property<string>("LastIP");

                    b.Property<ushort>("Level");

                    b.Property<ushort>("MP");

                    b.Property<byte[]>("MagicsBytes");

                    b.Property<int>("Married");

                    b.Property<DateTime>("MarriedDate");

                    b.Property<byte>("MentalState");

                    b.Property<byte>("MentalStateLvl");

                    b.Property<int>("Mentor");

                    b.Property<DateTime>("MentorDate");

                    b.Property<long>("MentorExp");

                    b.Property<string>("Name");

                    b.Property<bool>("NewDay");

                    b.Property<int>("PKPoints");

                    b.Property<byte>("PMode");

                    b.Property<int>("PearlCount");

                    b.Property<byte[]>("PetsBytes");

                    b.Property<string>("QuestInventoryString");

                    b.Property<byte[]>("RentedItemsBytes");

                    b.Property<bool>("Thrusting");

                    b.Property<bool>("isMentor");

                    b.HasKey("Index");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("Server.MirEnvir.MailInfo", b =>
                {
                    b.Property<ulong>("MailID")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("CanReply");

                    b.Property<bool>("Collected");

                    b.Property<DateTime>("DateOpened");

                    b.Property<DateTime>("DateSent");

                    b.Property<uint>("Gold");

                    b.Property<string>("ItemsString");

                    b.Property<bool>("Locked");

                    b.Property<string>("Message");

                    b.Property<int>("RecipientIndex");

                    b.Property<string>("Sender");

                    b.HasKey("MailID");

                    b.ToTable("Mails");
                });

            modelBuilder.Entity("UserItem", b =>
                {
                    b.Property<ulong>("UniqueID")
                        .ValueGeneratedOnAdd();

                    b.Property<byte>("AC");

                    b.Property<byte>("Accuracy");

                    b.Property<byte>("Agility");

                    b.Property<sbyte>("AttackSpeed");

                    b.Property<byte[]>("AwakeBytes");

                    b.Property<DateTime>("BuybackExpiryDate");

                    b.Property<uint>("Count");

                    b.Property<byte>("CriticalDamage");

                    b.Property<byte>("CriticalRate");

                    b.Property<ushort>("CurrentDura");

                    b.Property<bool>("Cursed");

                    b.Property<byte>("DC");

                    b.Property<bool>("DuraChanged");

                    b.Property<byte[]>("ExpireInfoBytes");

                    b.Property<byte>("Freezing");

                    b.Property<uint>("GemCount");

                    b.Property<byte>("HP");

                    b.Property<byte>("HealthRecovery");

                    b.Property<bool>("Identified");

                    b.Property<int>("ItemIndex");

                    b.Property<sbyte>("Luck");

                    b.Property<byte>("MAC");

                    b.Property<byte>("MC");

                    b.Property<byte>("MP");

                    b.Property<byte>("MagicResist");

                    b.Property<byte>("ManaRecovery");

                    b.Property<ushort>("MaxDura");

                    b.Property<byte>("PoisonAttack");

                    b.Property<byte>("PoisonRecovery");

                    b.Property<byte>("PoisonResist");

                    b.Property<byte>("RefineAdded");

                    b.Property<byte>("RefinedValue");

                    b.Property<byte[]>("RentalInformationBytes");

                    b.Property<byte>("SC");

                    b.Property<string>("SlotString");

                    b.Property<int>("SoulBoundId");

                    b.Property<byte>("Strong");

                    b.Property<int>("WeddingRing");

                    b.HasKey("UniqueID");

                    b.ToTable("UserItems");
                });
#pragma warning restore 612, 618
        }
    }
}
