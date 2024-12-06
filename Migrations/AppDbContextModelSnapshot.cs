﻿// <auto-generated />
using System;
using DocumentationWebSiteApi.Database.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DocumentationWebSiteApi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("DocumentationWebSiteApi.Database.Entities.AboutUs", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("AddressId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("DeletedBy")
                        .HasColumnType("uuid");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("UpdatedBy")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("AddressId")
                        .IsUnique();

                    b.ToTable("AboutUs");
                });

            modelBuilder.Entity("DocumentationWebSiteApi.Database.Entities.Address", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("DeletedBy")
                        .HasColumnType("uuid");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<double>("Latitude")
                        .HasColumnType("double precision");

                    b.Property<double>("Longitude")
                        .HasColumnType("double precision");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("UpdatedBy")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("DocumentationWebSiteApi.Database.Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("DeletedBy")
                        .HasColumnType("uuid");

                    b.Property<Guid>("HeadCategoryId")
                        .HasColumnType("uuid");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("UpdatedBy")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("HeadCategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("DocumentationWebSiteApi.Database.Entities.Contact", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("AboutUsId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("DeletedBy")
                        .HasColumnType("uuid");

                    b.Property<string>("Icon")
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("UpdatedBy")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("AboutUsId");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("DocumentationWebSiteApi.Database.Entities.Content", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("DeletedBy")
                        .HasColumnType("uuid");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<Guid>("TopicId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("UpdatedBy")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("TopicId");

                    b.ToTable("Contents");
                });

            modelBuilder.Entity("DocumentationWebSiteApi.Database.Entities.HeadCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("DeletedBy")
                        .HasColumnType("uuid");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("UpdatedBy")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.ToTable("HeadCategories");
                });

            modelBuilder.Entity("DocumentationWebSiteApi.Database.Entities.Language", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("DeletedBy")
                        .HasColumnType("uuid");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("UpdatedBy")
                        .HasColumnType("uuid");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Key")
                        .IsUnique();

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("DocumentationWebSiteApi.Database.Entities.MultiLanguageText", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("AboutUsId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("AddressId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("CategoryId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("ContactId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("ContentId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("DeletedBy")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("HeadCategoryId")
                        .HasColumnType("uuid");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<Guid>("LanguageId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("LanguageId1")
                        .HasColumnType("uuid");

                    b.Property<int>("MetaDataType")
                        .HasColumnType("integer");

                    b.Property<Guid?>("MultiLanguageTextId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("SubCategoryId")
                        .HasColumnType("uuid");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid?>("TopicId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("UpdatedBy")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("UploadedFileId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("AboutUsId");

                    b.HasIndex("AddressId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ContactId");

                    b.HasIndex("ContentId");

                    b.HasIndex("HeadCategoryId");

                    b.HasIndex("LanguageId1");

                    b.HasIndex("MultiLanguageTextId");

                    b.HasIndex("SubCategoryId");

                    b.HasIndex("TopicId");

                    b.HasIndex("UploadedFileId");

                    b.HasIndex("UserId");

                    b.HasIndex("LanguageId", "MetaDataType", "AboutUsId")
                        .IsUnique();

                    b.HasIndex("LanguageId", "MetaDataType", "AddressId")
                        .IsUnique();

                    b.HasIndex("LanguageId", "MetaDataType", "CategoryId")
                        .IsUnique();

                    b.HasIndex("LanguageId", "MetaDataType", "ContactId")
                        .IsUnique();

                    b.HasIndex("LanguageId", "MetaDataType", "ContentId")
                        .IsUnique();

                    b.HasIndex("LanguageId", "MetaDataType", "HeadCategoryId")
                        .IsUnique();

                    b.HasIndex("LanguageId", "MetaDataType", "SubCategoryId")
                        .IsUnique();

                    b.HasIndex("LanguageId", "MetaDataType", "TopicId")
                        .IsUnique();

                    b.ToTable("MultiLanguageTexts");
                });

            modelBuilder.Entity("DocumentationWebSiteApi.Database.Entities.SubCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("DeletedBy")
                        .HasColumnType("uuid");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("UpdatedBy")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("SubCategories");
                });

            modelBuilder.Entity("DocumentationWebSiteApi.Database.Entities.Topic", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("DeletedBy")
                        .HasColumnType("uuid");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<Guid>("SubCategoryId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("UpdatedBy")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("SubCategoryId");

                    b.ToTable("Topics");
                });

            modelBuilder.Entity("DocumentationWebSiteApi.Database.Entities.UploadedFile", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Alt")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("ContentId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("DeletedBy")
                        .HasColumnType("uuid");

                    b.Property<string>("FileExtention")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FilePath")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FileSize")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FileUrl")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("UpdatedBy")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("ContentId");

                    b.HasIndex("FileName")
                        .IsUnique();

                    b.ToTable("UploadedFiles");
                });

            modelBuilder.Entity("DocumentationWebSiteApi.Database.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("DeletedBy")
                        .HasColumnType("uuid");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("UpdatedBy")
                        .HasColumnType("uuid");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DocumentationWebSiteApi.Database.Entities.AboutUs", b =>
                {
                    b.HasOne("DocumentationWebSiteApi.Database.Entities.Address", "Address")
                        .WithOne()
                        .HasForeignKey("DocumentationWebSiteApi.Database.Entities.AboutUs", "AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");
                });

            modelBuilder.Entity("DocumentationWebSiteApi.Database.Entities.Category", b =>
                {
                    b.HasOne("DocumentationWebSiteApi.Database.Entities.HeadCategory", "HeadCategory")
                        .WithMany("Categories")
                        .HasForeignKey("HeadCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HeadCategory");
                });

            modelBuilder.Entity("DocumentationWebSiteApi.Database.Entities.Contact", b =>
                {
                    b.HasOne("DocumentationWebSiteApi.Database.Entities.AboutUs", "AboutUs")
                        .WithMany("Contacts")
                        .HasForeignKey("AboutUsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AboutUs");
                });

            modelBuilder.Entity("DocumentationWebSiteApi.Database.Entities.Content", b =>
                {
                    b.HasOne("DocumentationWebSiteApi.Database.Entities.Topic", "Topic")
                        .WithMany("Contents")
                        .HasForeignKey("TopicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Topic");
                });

            modelBuilder.Entity("DocumentationWebSiteApi.Database.Entities.MultiLanguageText", b =>
                {
                    b.HasOne("DocumentationWebSiteApi.Database.Entities.AboutUs", "AboutUs")
                        .WithMany("MultiLanguageTexts")
                        .HasForeignKey("AboutUsId");

                    b.HasOne("DocumentationWebSiteApi.Database.Entities.Address", "Address")
                        .WithMany("MultiLanguageTexts")
                        .HasForeignKey("AddressId");

                    b.HasOne("DocumentationWebSiteApi.Database.Entities.Category", "Category")
                        .WithMany("MultiLanguageTexts")
                        .HasForeignKey("CategoryId");

                    b.HasOne("DocumentationWebSiteApi.Database.Entities.Contact", "Contact")
                        .WithMany("MultiLanguageTexts")
                        .HasForeignKey("ContactId");

                    b.HasOne("DocumentationWebSiteApi.Database.Entities.Content", "Content")
                        .WithMany("MultiLanguageTexts")
                        .HasForeignKey("ContentId");

                    b.HasOne("DocumentationWebSiteApi.Database.Entities.HeadCategory", "HeadCategory")
                        .WithMany("MultiLanguageTexts")
                        .HasForeignKey("HeadCategoryId");

                    b.HasOne("DocumentationWebSiteApi.Database.Entities.Language", "Language")
                        .WithMany("Texts")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DocumentationWebSiteApi.Database.Entities.Language", null)
                        .WithMany("MultiLanguageTexts")
                        .HasForeignKey("LanguageId1");

                    b.HasOne("DocumentationWebSiteApi.Database.Entities.MultiLanguageText", null)
                        .WithMany("MultiLanguageTexts")
                        .HasForeignKey("MultiLanguageTextId");

                    b.HasOne("DocumentationWebSiteApi.Database.Entities.SubCategory", "SubCategory")
                        .WithMany("MultiLanguageTexts")
                        .HasForeignKey("SubCategoryId");

                    b.HasOne("DocumentationWebSiteApi.Database.Entities.Topic", "Topic")
                        .WithMany("MultiLanguageTexts")
                        .HasForeignKey("TopicId");

                    b.HasOne("DocumentationWebSiteApi.Database.Entities.UploadedFile", null)
                        .WithMany("MultiLanguageTexts")
                        .HasForeignKey("UploadedFileId");

                    b.HasOne("DocumentationWebSiteApi.Database.Entities.User", null)
                        .WithMany("MultiLanguageTexts")
                        .HasForeignKey("UserId");

                    b.Navigation("AboutUs");

                    b.Navigation("Address");

                    b.Navigation("Category");

                    b.Navigation("Contact");

                    b.Navigation("Content");

                    b.Navigation("HeadCategory");

                    b.Navigation("Language");

                    b.Navigation("SubCategory");

                    b.Navigation("Topic");
                });

            modelBuilder.Entity("DocumentationWebSiteApi.Database.Entities.SubCategory", b =>
                {
                    b.HasOne("DocumentationWebSiteApi.Database.Entities.Category", "Category")
                        .WithMany("SubCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("DocumentationWebSiteApi.Database.Entities.Topic", b =>
                {
                    b.HasOne("DocumentationWebSiteApi.Database.Entities.SubCategory", "SubCategory")
                        .WithMany("Topics")
                        .HasForeignKey("SubCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SubCategory");
                });

            modelBuilder.Entity("DocumentationWebSiteApi.Database.Entities.UploadedFile", b =>
                {
                    b.HasOne("DocumentationWebSiteApi.Database.Entities.Content", "Content")
                        .WithMany("Images")
                        .HasForeignKey("ContentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Content");
                });

            modelBuilder.Entity("DocumentationWebSiteApi.Database.Entities.AboutUs", b =>
                {
                    b.Navigation("Contacts");

                    b.Navigation("MultiLanguageTexts");
                });

            modelBuilder.Entity("DocumentationWebSiteApi.Database.Entities.Address", b =>
                {
                    b.Navigation("MultiLanguageTexts");
                });

            modelBuilder.Entity("DocumentationWebSiteApi.Database.Entities.Category", b =>
                {
                    b.Navigation("MultiLanguageTexts");

                    b.Navigation("SubCategories");
                });

            modelBuilder.Entity("DocumentationWebSiteApi.Database.Entities.Contact", b =>
                {
                    b.Navigation("MultiLanguageTexts");
                });

            modelBuilder.Entity("DocumentationWebSiteApi.Database.Entities.Content", b =>
                {
                    b.Navigation("Images");

                    b.Navigation("MultiLanguageTexts");
                });

            modelBuilder.Entity("DocumentationWebSiteApi.Database.Entities.HeadCategory", b =>
                {
                    b.Navigation("Categories");

                    b.Navigation("MultiLanguageTexts");
                });

            modelBuilder.Entity("DocumentationWebSiteApi.Database.Entities.Language", b =>
                {
                    b.Navigation("MultiLanguageTexts");

                    b.Navigation("Texts");
                });

            modelBuilder.Entity("DocumentationWebSiteApi.Database.Entities.MultiLanguageText", b =>
                {
                    b.Navigation("MultiLanguageTexts");
                });

            modelBuilder.Entity("DocumentationWebSiteApi.Database.Entities.SubCategory", b =>
                {
                    b.Navigation("MultiLanguageTexts");

                    b.Navigation("Topics");
                });

            modelBuilder.Entity("DocumentationWebSiteApi.Database.Entities.Topic", b =>
                {
                    b.Navigation("Contents");

                    b.Navigation("MultiLanguageTexts");
                });

            modelBuilder.Entity("DocumentationWebSiteApi.Database.Entities.UploadedFile", b =>
                {
                    b.Navigation("MultiLanguageTexts");
                });

            modelBuilder.Entity("DocumentationWebSiteApi.Database.Entities.User", b =>
                {
                    b.Navigation("MultiLanguageTexts");
                });
#pragma warning restore 612, 618
        }
    }
}