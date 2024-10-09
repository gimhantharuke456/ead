package com.example.teaapp;

@kotlin.Metadata(mv = {1, 9, 0}, k = 1, xi = 48, d1 = {"\u0000X\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u000e\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\u0018\u00002\u00020\u0001B\u0005\u00a2\u0006\u0002\u0010\u0002J\u0012\u0010\u0014\u001a\u00020\u00152\b\u0010\u0016\u001a\u0004\u0018\u00010\u0017H\u0002J\u0010\u0010\u0018\u001a\u00020\u00152\u0006\u0010\u0016\u001a\u00020\u0017H\u0002J\u0010\u0010\u0019\u001a\u00020\u00152\u0006\u0010\u001a\u001a\u00020\u001bH\u0002J\u0012\u0010\u001c\u001a\u00020\u00152\b\u0010\u001d\u001a\u0004\u0018\u00010\u001eH\u0014R\u000e\u0010\u0003\u001a\u00020\u0004X\u0082.\u00a2\u0006\u0002\n\u0000R\u000e\u0010\u0005\u001a\u00020\u0006X\u0082.\u00a2\u0006\u0002\n\u0000R\u000e\u0010\u0007\u001a\u00020\bX\u0082.\u00a2\u0006\u0002\n\u0000R\u000e\u0010\t\u001a\u00020\nX\u0082.\u00a2\u0006\u0002\n\u0000R\u000e\u0010\u000b\u001a\u00020\bX\u0082.\u00a2\u0006\u0002\n\u0000R\u000e\u0010\f\u001a\u00020\bX\u0082.\u00a2\u0006\u0002\n\u0000R\u000e\u0010\r\u001a\u00020\u000eX\u0082.\u00a2\u0006\u0002\n\u0000R\u000e\u0010\u000f\u001a\u00020\u0010X\u0082.\u00a2\u0006\u0002\n\u0000R\u0014\u0010\u0011\u001a\b\u0012\u0004\u0012\u00020\u00130\u0012X\u0082\u000e\u00a2\u0006\u0002\n\u0000\u00a8\u0006\u001f"}, d2 = {"Lcom/example/teaapp/SIngleShopItemActivity;", "Landroidx/appcompat/app/AppCompatActivity;", "()V", "addToCartButton", "Landroid/widget/Button;", "cartService", "Lcom/example/teaapp/DatabaseHelper;", "itemDescription", "Landroid/widget/TextView;", "itemImage", "Landroid/widget/ImageView;", "itemName", "itemPrice", "reviewAdapter", "Lcom/example/teaapp/ReviewAdapter;", "reviewRecyclerView", "Landroidx/recyclerview/widget/RecyclerView;", "reviews", "", "Lcom/example/teaapp/dto/CreateReviewResponse;", "addToCart", "", "shopItem", "Lcom/example/teaapp/model/ShopItem;", "displayShopItem", "fetchReviews", "shopItemId", "", "onCreate", "savedInstanceState", "Landroid/os/Bundle;", "app_debug"})
public final class SIngleShopItemActivity extends androidx.appcompat.app.AppCompatActivity {
    private android.widget.ImageView itemImage;
    private android.widget.TextView itemName;
    private android.widget.TextView itemPrice;
    private android.widget.TextView itemDescription;
    private android.widget.Button addToCartButton;
    private com.example.teaapp.DatabaseHelper cartService;
    private androidx.recyclerview.widget.RecyclerView reviewRecyclerView;
    private com.example.teaapp.ReviewAdapter reviewAdapter;
    @org.jetbrains.annotations.NotNull
    private java.util.List<com.example.teaapp.dto.CreateReviewResponse> reviews;
    
    public SIngleShopItemActivity() {
        super();
    }
    
    @java.lang.Override
    protected void onCreate(@org.jetbrains.annotations.Nullable
    android.os.Bundle savedInstanceState) {
    }
    
    private final void displayShopItem(com.example.teaapp.model.ShopItem shopItem) {
    }
    
    private final void fetchReviews(java.lang.String shopItemId) {
    }
    
    private final void addToCart(com.example.teaapp.model.ShopItem shopItem) {
    }
}