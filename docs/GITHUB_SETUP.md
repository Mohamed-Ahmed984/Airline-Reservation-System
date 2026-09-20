# Publish This Repository to GitHub

The local repository already contains the commits and branches. To publish it:

1. Create an empty GitHub repository named `Airline-Reservation-System`.
2. Do not add a README, `.gitignore`, or license on GitHub because they already exist locally.
3. Open a terminal inside this project folder.
4. Add your repository as the remote:

   ```bash
   git remote add origin https://github.com/Mohamed-Ahmed984/Airline-Reservation-System.git
   ```

5. Push the main branch:

   ```bash
   git push -u origin main
   ```

6. Push all remaining branches:

   ```bash
   git push origin --all
   ```

## Included Branches

- `main`
- `develop`
- `feature/passenger-management`
- `feature/flight-management`
- `feature/filtering-and-reports`
- `docs/readme`

After pushing, keep `main` as the default branch and use `develop` as the base for future feature work.
