package com.example.teaapp;

@kotlin.Metadata(mv = {1, 9, 0}, k = 1, xi = 48, d1 = {"\u0000<\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\t\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\u0002\n\u0002\u0010 \n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0006\u0018\u0000 \u00172\u00020\u0001:\u0001\u0017B\r\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u00a2\u0006\u0002\u0010\u0004J\u000e\u0010\u0005\u001a\u00020\u00062\u0006\u0010\u0007\u001a\u00020\bJ\u0006\u0010\t\u001a\u00020\nJ\u000e\u0010\u000b\u001a\u00020\f2\u0006\u0010\r\u001a\u00020\u0006J\u000e\u0010\u000e\u001a\b\u0012\u0004\u0012\u00020\b0\u000fH\u0007J\u0010\u0010\u0010\u001a\u00020\n2\u0006\u0010\u0011\u001a\u00020\u0012H\u0016J \u0010\u0013\u001a\u00020\n2\u0006\u0010\u0011\u001a\u00020\u00122\u0006\u0010\u0014\u001a\u00020\f2\u0006\u0010\u0015\u001a\u00020\fH\u0016J\u000e\u0010\u0016\u001a\u00020\f2\u0006\u0010\u0007\u001a\u00020\b\u00a8\u0006\u0018"}, d2 = {"Lcom/example/teaapp/DatabaseHelper;", "Landroid/database/sqlite/SQLiteOpenHelper;", "context", "Landroid/content/Context;", "(Landroid/content/Context;)V", "addCartItem", "", "cartItem", "Lcom/example/teaapp/model/CartItem;", "clearCart", "", "deleteCartItem", "", "itemId", "getCartItems", "", "onCreate", "db", "Landroid/database/sqlite/SQLiteDatabase;", "onUpgrade", "oldVersion", "newVersion", "updateCartItem", "Companion", "app_debug"})
public final class DatabaseHelper extends android.database.sqlite.SQLiteOpenHelper {
    @org.jetbrains.annotations.NotNull
    private static final java.lang.String DATABASE_NAME = "cart.db";
    private static final int DATABASE_VERSION = 1;
    @org.jetbrains.annotations.NotNull
    private static final java.lang.String TABLE_CART = "cart";
    @org.jetbrains.annotations.NotNull
    private static final java.lang.String COLUMN_ID = "id";
    @org.jetbrains.annotations.NotNull
    private static final java.lang.String COLUMN_ITEM_ID = "itemId";
    @org.jetbrains.annotations.NotNull
    private static final java.lang.String COLUMN_ITEM_NAME = "itemName";
    @org.jetbrains.annotations.NotNull
    private static final java.lang.String COLUMN_ITEM_PRICE = "itemPrice";
    @org.jetbrains.annotations.NotNull
    private static final java.lang.String COLUMN_QUANTITY = "quantity";
    @org.jetbrains.annotations.NotNull
    private static final java.lang.String COLUMN_IMAGE_URL = "imageUrl";
    @org.jetbrains.annotations.NotNull
    public static final com.example.teaapp.DatabaseHelper.Companion Companion = null;
    
    public DatabaseHelper(@org.jetbrains.annotations.NotNull
    android.content.Context context) {
        super(null, null, null, 0);
    }
    
    @java.lang.Override
    public void onCreate(@org.jetbrains.annotations.NotNull
    android.database.sqlite.SQLiteDatabase db) {
    }
    
    @java.lang.Override
    public void onUpgrade(@org.jetbrains.annotations.NotNull
    android.database.sqlite.SQLiteDatabase db, int oldVersion, int newVersion) {
    }
    
    public final long addCartItem(@org.jetbrains.annotations.NotNull
    com.example.teaapp.model.CartItem cartItem) {
        return 0L;
    }
    
    @android.annotation.SuppressLint(value = {"Range"})
    @org.jetbrains.annotations.NotNull
    public final java.util.List<com.example.teaapp.model.CartItem> getCartItems() {
        return null;
    }
    
    public final int updateCartItem(@org.jetbrains.annotations.NotNull
    com.example.teaapp.model.CartItem cartItem) {
        return 0;
    }
    
    public final int deleteCartItem(long itemId) {
        return 0;
    }
    
    public final void clearCart() {
    }
    
    @kotlin.Metadata(mv = {1, 9, 0}, k = 1, xi = 48, d1 = {"\u0000\u001c\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0002\b\u0007\n\u0002\u0010\b\n\u0002\b\u0002\b\u0086\u0003\u0018\u00002\u00020\u0001B\u0007\b\u0002\u00a2\u0006\u0002\u0010\u0002R\u000e\u0010\u0003\u001a\u00020\u0004X\u0082T\u00a2\u0006\u0002\n\u0000R\u000e\u0010\u0005\u001a\u00020\u0004X\u0082T\u00a2\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0004X\u0082T\u00a2\u0006\u0002\n\u0000R\u000e\u0010\u0007\u001a\u00020\u0004X\u0082T\u00a2\u0006\u0002\n\u0000R\u000e\u0010\b\u001a\u00020\u0004X\u0082T\u00a2\u0006\u0002\n\u0000R\u000e\u0010\t\u001a\u00020\u0004X\u0082T\u00a2\u0006\u0002\n\u0000R\u000e\u0010\n\u001a\u00020\u0004X\u0082T\u00a2\u0006\u0002\n\u0000R\u000e\u0010\u000b\u001a\u00020\fX\u0082T\u00a2\u0006\u0002\n\u0000R\u000e\u0010\r\u001a\u00020\u0004X\u0082T\u00a2\u0006\u0002\n\u0000\u00a8\u0006\u000e"}, d2 = {"Lcom/example/teaapp/DatabaseHelper$Companion;", "", "()V", "COLUMN_ID", "", "COLUMN_IMAGE_URL", "COLUMN_ITEM_ID", "COLUMN_ITEM_NAME", "COLUMN_ITEM_PRICE", "COLUMN_QUANTITY", "DATABASE_NAME", "DATABASE_VERSION", "", "TABLE_CART", "app_debug"})
    public static final class Companion {
        
        private Companion() {
            super();
        }
    }
}