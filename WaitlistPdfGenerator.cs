using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System;

public static class WaitlistPdfGenerator
{
    // ⚠ IMPORTANT : obligatoire pour QuestPDF 2024+, sinon PDF vide
    static WaitlistPdfGenerator()
    {
        QuestPDF.Settings.License = LicenseType.Community;
    }

    public static void GenererAttente(
        string nomClient,
        string nomArticle,
        int quantiteDemandee,
        int quantiteDisponible,
        DateTime dateDemande)
    {
        var model = new WaitlistModel
        {
            NomClient = nomClient,
            NomArticle = nomArticle,
            QuantiteDemandee = quantiteDemandee,
            QuantiteDisponible = quantiteDisponible,
            DateDemande = dateDemande
        };

        var document = new WaitlistDocument(model);
        document.GeneratePdf("attente.pdf");

        Console.WriteLine("📄 PDF d’attente généré : attente.pdf");
    }
}


// =============================
//  📄 DONNÉES DU DOCUMENT
// =============================
public class WaitlistModel
{
    public string NomClient { get; set; }
    public string NomArticle { get; set; }
    public int QuantiteDemandee { get; set; }
    public int QuantiteDisponible { get; set; }
    public DateTime DateDemande { get; set; }
}


// =============================
//   📄 TEMPLATE DU DOCUMENT
// =============================
public class WaitlistDocument : IDocument
{
    private readonly WaitlistModel Model;

    public WaitlistDocument(WaitlistModel model)
    {
        Model = model;
    }

    public DocumentMetadata GetMetadata() => new DocumentMetadata
    {
        Title = "Mise en Attente - Rupture de Stock"
    };

    public void Compose(IDocumentContainer container)
    {
        container.Page(page =>
        {
            page.Margin(40);
            page.DefaultTextStyle(x => x.FontSize(14));

            // HEADER
            page.Header().Text("MISE EN ATTENTE - RUPTURE DE STOCK")
                .SemiBold().FontSize(26).FontColor(Colors.Orange.Medium);

            // CONTENU
            page.Content().Column(col =>
            {
                col.Item().Text($"Date : {Model.DateDemande}");
                col.Item().Text($"Client : {Model.NomClient}");
                col.Item().Text($"Article demandé : {Model.NomArticle}");
                col.Item().Text($"Quantité demandée : {Model.QuantiteDemandee}");
                col.Item().Text($"Quantité disponible : {Model.QuantiteDisponible}");

                col.Item().PaddingVertical(10);

                col.Item().Text("⚠ L'article est temporairement indisponible.")
                    .SemiBold().FontColor(Colors.Red.Medium);

                col.Item().Text("Le client est placé en liste d'attente.")
                    .Italic().FontColor(Colors.Grey.Darken2);
            });

            // FOOTER
            page.Footer()
                .AlignCenter()
                .Text("GestionStock - Document généré automatiquement");
        });
    }
}
