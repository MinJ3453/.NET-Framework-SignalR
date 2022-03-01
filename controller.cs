  public ActionResult index()
        {
            ViewBag.Nname = AuthorizedUser.DisplayName; //접속한 닉네임
            return View();
        }
